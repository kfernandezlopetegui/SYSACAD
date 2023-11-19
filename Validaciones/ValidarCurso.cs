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

        public async static Task<Curso> VerificarSiExisteCurso(string codigo)
        {
            

            Curso cursoEncontrado = await CRUDB.ObtenerPorIdentificadorAsync<Curso>("Curso", "Codigo = @Codigo", new { Codigo = codigo }); 


            return cursoEncontrado;


        }

        public async static Task<bool> VerificarRequisitos(RequisitosAcademicos requisito, int idAlumno)
        {
            Alumno alumnoEncontrado = await CRUDB.ObtenerPorIdentificadorAsync<Alumno>("Alumno", "Dni = @Dni", new { Dni = idAlumno });
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
