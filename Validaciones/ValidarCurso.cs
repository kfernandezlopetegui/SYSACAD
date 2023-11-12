using DB;
using Entidades;
using LecturaEscritura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    public class ValidarCurso
    {
        private List<Curso> listaCursos = new List<Curso>();

        public ValidarCurso() { }   

        public static Curso VerificarSiExisteCurso(string codigo)
        {
            

            Curso cursoEncontrado = CRUDB.ObtenerPorIdentificador<Curso>("Curso", "Codigo = @Codigo", new { Codigo = codigo }); 


            return cursoEncontrado;


        }

        public static bool VerificarRequisitos(RequisitosAcademicos requisito, int idAlumno)
        {
            Alumno alumnoEncontrado = CRUDB.ObtenerPorIdentificador<Alumno>("Alumno", "Dni = @Dni", new { Dni = idAlumno });
            RequisitosAcademicos requisitosCurso = requisito;
            List<string> listaCursosCorrelativos = CRUD.ConvertirJsonALista(requisitosCurso.IdCursosAprobadosJson);
            List<string> cursosAprobadosAlumno = CRUD.ConvertirJsonALista(alumnoEncontrado.CursosAprobados);
            bool tieneLasMateriasCorrelativas = listaCursosCorrelativos.All(curso => cursosAprobadosAlumno.Contains(curso));
            bool cumpleCreditosMinimos = alumnoEncontrado.Creditos >= requisitosCurso.CantidadMinimaCreditos;
            bool cumplePromedioMinimo = alumnoEncontrado.Promedio >= requisitosCurso.PromedioMinimo;
            if (cumpleCreditosMinimos && cumplePromedioMinimo && tieneLasMateriasCorrelativas)
            {
                return true;
            }

            return false;
        }
    }
}
