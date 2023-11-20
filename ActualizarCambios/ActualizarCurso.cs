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
        
        public async static void AgregarCursoBD(Curso nuevoCurso)
        { 
          
            await CRUDB.InsertarRegistroAsync<Curso>(nuevoCurso);
        }

        public async static void BorrarCursoPorCodigoBD(string codigo)
        {
            
           await CRUDB.EliminarPorCondicionAsync<Curso>("Curso", "Codigo", codigo);

        }

        public async static void EditarCursoBD(Curso curso, string codigoOriginal)
        {
            /* Edita el curso
             * recibe el curso a guardar, el codigo original del curso que se esta editando
             * 
             */
            await CRUDB.ActualizarPorIdentificadorAsync("Curso", "Codigo", codigoOriginal, curso);
        }
        public async static void EditarCursoBD(Curso curso)
        {
            /* Edita el curso
             * recibe el curso a guardar
             * 
             */
            await CRUDB.ActualizarPorIdentificadorAsync("Curso", "Codigo", curso.Codigo, curso);
        }
        public static bool VerificarCupo(Curso curso)
        {
            if(curso.CupoActual < curso.CupoMaximo )
            {
                return true;
            }
            return false;
        }

        public async static void ActualizarCupo(string codigoCurso)
        {
            /* Edita el curso
             * recibe el curso a guardar, el codigo original del curso que se esta editando
             *  
             */
           
            
            Curso cursoEncontrado = await CRUDB.ObtenerPorIdentificadorAsync<Curso>("Curso", "Codigo = @Codigo", new { Codigo = codigoCurso });

            cursoEncontrado.SumarInscripto();
            EditarCursoBD(cursoEncontrado);


        }

        public async static Task<bool> VerificarCupoOnline(Curso curso)
        {

            Curso cursoObtenido = await CRUDB.ObtenerPorIdentificadorAsync<Curso>("Curso", "Codigo = @Codigo", new {Codigo = curso.Codigo }); 

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

        public async static void AgregarAListaEspera(ListaEspera listaEspera)
        {
            await CRUDB.InsertarRegistroAsync<ListaEspera>(listaEspera);
        }
    
        

    }
}
