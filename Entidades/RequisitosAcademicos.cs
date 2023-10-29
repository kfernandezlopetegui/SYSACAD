using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RequisitosAcademicos
    {
        // Propiedades de los requisitos académicos
        public List<int> IdCursosAprobados { get; set; }
        public int CantidadMinimaCreditos { get; set; }
        public double PromedioMinimo { get; set; }

        // Constructor
        public RequisitosAcademicos(List<int> idCursosAprobados, int cantidadMinimaCreditos, double promedioMinimo)
        {
            IdCursosAprobados = idCursosAprobados;
            CantidadMinimaCreditos = cantidadMinimaCreditos;
            PromedioMinimo = promedioMinimo;
        }

        // Método para verificar si un estudiante cumple con los requisitos
        public bool CumpleRequisitos(Alumno estudiante)
        {
            // Verificar si el estudiante tiene los cursos aprobados previamente
            foreach (int idCurso in IdCursosAprobados)
            {
                if (!estudiante.CursosAprobados.Contains(idCurso))
                {
                    return false;
                }
            }

            // Verificar la cantidad mínima de créditos
            if (estudiante.Creditos < CantidadMinimaCreditos)
            {
                return false;
            }

            // Verificar el promedio mínimo
            if (estudiante.Promedio < PromedioMinimo)
            {
                return false;
            }

            // Si pasa todas las verificaciones, el estudiante cumple con los requisitos
            return true;
        }
    }
}
