using DB;
using Entidades;
using LecturaEscritura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

namespace Actualizar
{
    public class ActualizarCurso
    {
       
        public static List<Curso> ListaCursosActualesBD()
        {
            List<Curso> cursosRegistrados = CRUDB.ObtenerTodos<Curso>("Curso");
            return cursosRegistrados;
        }
        
       
        public static void AgregarCursoBD(Curso nuevoCurso)
        { 
           DataBase.InsertarRegistro<Curso>(nuevoCurso);
        }

        public static void BorrarCursoPorCodigoBD(string codigo)
        {
            
            CRUDB.EliminarPorCondicion<Curso>("Curso", "Codigo", codigo);

        }

        public static void EditarCursoBD(Curso curso, string codigoOriginal)
        {
            /* Edita el curso
             * recibe el curso a guardar, el codigo original del curso que se esta editando
             * 
             */
            CRUDB.ActualizarPorIdentificador("Curso", "Codigo", codigoOriginal, curso);
        }
        public static void EditarCursoBD(Curso curso)
        {
            /* Edita el curso
             * recibe el curso a guardar
             * 
             */
            CRUDB.ActualizarPorIdentificador("Curso", "Codigo", curso.Codigo, curso);
        }
        public static bool VerificarCupo(Curso curso)
        {
            if(curso.CupoActual < curso.CupoMaximo )
            {
                return true;
            }
            return false;
        }


        public static void ActualizarCupo( string file, string codigoCurso)
        {
            /* Edita el curso
             * recibe el curso a guardar, el codigo original del curso que se esta editando
             *  
             */
           
            
            Curso cursoEncontrado = CRUDB.ObtenerPorIdentificador<Curso>("Curso", "Codigo = @Codigo", new { Codigo = codigoCurso });

            cursoEncontrado.SumarInscripto();
            EditarCursoBD(cursoEncontrado);


        }

        public static bool VerificarCupoOnline(Curso curso)
        {

            Curso cursoObtenido = CRUDB.ObtenerPorIdentificador<Curso>("Curso", "Codigo = @Codigo", new {Codigo = curso.Codigo }); 

            return VerificarCupo(cursoObtenido);
        }

        public static List<Curso> ObtenerCursosAlumno(string fileCursos, string fileInscripciones,  int idAlumnoLogueado)

        {
            List<Curso> listaCursos = ListaCursosActualesBD();
            List<Inscripcion> listaInscripciones = ActualizarInscripciones.ListaInscripcionesActuales();
            var cursosDelAlumno = from inscripcion in listaInscripciones
                                  where inscripcion.AlumnoId == idAlumnoLogueado
                                  join curso in listaCursos on inscripcion.CursoId equals curso.Codigo
                                  select curso;
            return cursosDelAlumno.ToList();
        }

        public static string ObtenerNombreCursoPorCodigo(List<string> listaCodigosCurso)
        {
            List<Curso> listaCursos = ListaCursosActualesBD();
            List<string> nombresCursosEncontrados = new List<string>();

            foreach (var codigoCurso in listaCodigosCurso)
            {
                var cursoEncontrado = listaCursos.FirstOrDefault(curso => curso.Codigo == codigoCurso);
                if (cursoEncontrado != null)
                {
                    nombresCursosEncontrados.Add(cursoEncontrado.Nombre);
                }
            }

            string nombresSeparadosPorComas = string.Join(", ", nombresCursosEncontrados);
            return nombresSeparadosPorComas;
        }

    }
}
