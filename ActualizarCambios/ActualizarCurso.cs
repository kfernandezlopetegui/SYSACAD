using Entidades;
using LecturaEscritura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

namespace Actualizar
{
    public class ActualizarCurso
    {
        public static List<Curso> ListaCursosActuales(string file)
        {
            List<Curso> usuariosRegistrados = CRUD.ReadStreamJSON<Curso>(file);
            return usuariosRegistrados;
        }
        public static Curso GetCurso(string file, string codigo)
        {
            List<Curso> listaCursos = ListaCursosActuales(file);
            Curso ?cursoEncontrado = listaCursos.FirstOrDefault(u => u.Codigo == codigo);
            return cursoEncontrado;
        }
       
        public static void AgregarCurso(string file, Curso nuevoCurso)
        {
            // Leer la lista existente desde el archivo JSON
            List<Curso> listaCursos = ListaCursosActuales(file);

            // Agregar el nuevo usuario a la lista
            listaCursos.Add(nuevoCurso);

            // Escribir la lista actualizada en el archivo JSON
            CRUD.WriteStreamJSON(file, listaCursos);
        }

        public static void BorrarCursoPorCodigo(string codigo, string file)
        {
            List<Curso> listaCursos = ListaCursosActuales(file);
            Curso cursoEncontrado = listaCursos.FirstOrDefault(u => u.Codigo == codigo);
            listaCursos.Remove(cursoEncontrado);
            CRUD.WriteStreamJSON(file, listaCursos);
            
        }

        public static void EditarCurso(Curso curso, string file, string codigoOriginal)
        {
            /* Edita el curso
             * recibe el curso a guardar, el codigo original del curso que se esta editando
             * y el lugar donde se guarda el archivo para persistir los datos  
             */
            List<Curso> listaCursos = ListaCursosActuales(file);
            Curso cursoEncontrado = listaCursos.FirstOrDefault(u => u.Codigo == codigoOriginal);
            cursoEncontrado.Codigo = curso.Codigo;
            cursoEncontrado.CupoMaximo = curso.CupoMaximo;
            cursoEncontrado.Nombre = curso.Nombre;
            cursoEncontrado.Descripcion = curso.Descripcion;

            CRUD.WriteStreamJSON(file, listaCursos);
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
             * y el lugar donde se guarda el archivo para persistir los datos  
             */
           
            List<Curso> listaCursos = ListaCursosActuales(file);
            Curso cursoEncontrado = listaCursos.FirstOrDefault(u => u.Codigo == codigoCurso);

            cursoEncontrado.SumarInscripto();
            CRUD.WriteStreamJSON(file, listaCursos);
        }

        public static bool VerificarCupoOnline(Curso curso, string file)
        {
            Curso cursoObtenido = GetCurso(file, curso.Codigo);

            return VerificarCupo(cursoObtenido);
        }

        public static List<Curso> ObtenerCursosAlumno(string fileCursos, string fileInscripciones,  int idAlumnoLogueado)

        {
            List<Curso> listaCursos = ListaCursosActuales(fileCursos);
            List<Inscripcion> listaInscripciones = ActualizarInscripciones.ListaInscripcionesActuales(fileInscripciones);
            var cursosDelAlumno = from inscripcion in listaInscripciones
                                  where inscripcion.AlumnoId == idAlumnoLogueado
                                  join curso in listaCursos on inscripcion.CursoId equals curso.Codigo
                                  select curso;
            return cursosDelAlumno.ToList();
        }

    }
}
