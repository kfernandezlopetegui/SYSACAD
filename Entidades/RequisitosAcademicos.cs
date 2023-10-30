using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RequisitosAcademicos
    {
        public RequisitosAcademicos() { }

        
        public List<string> IdCursosAprobados { get; set; }
        public int CantidadMinimaCreditos { get; set; }
        public double PromedioMinimo { get; set; }
        public int Id {  get; set; }

       
        public RequisitosAcademicos(List<string> idCursosAprobados, int cantidadMinimaCreditos, double promedioMinimo)
        {
            IdCursosAprobados = idCursosAprobados;
            CantidadMinimaCreditos = cantidadMinimaCreditos;
            PromedioMinimo = promedioMinimo;
            Id = GenerarIdUnico();
        }

       
        public bool CumpleRequisitos(Alumno estudiante)
        {
          
            foreach (string idCurso in IdCursosAprobados)
            {
                if (!estudiante.CursosAprobados.Contains(idCurso))
                {
                    return false;
                }
            }
           
            if (estudiante.Creditos < CantidadMinimaCreditos)
            {
                return false;
            }

           
            if (estudiante.Promedio < PromedioMinimo)
            {
                return false;
            }

            
            return true;
        }

        public int GenerarIdUnico()
        {
           
            DateTime now = DateTime.Now;

           
            int idUnico = int.Parse($"{now:yyyyMMddHHmmssfff}{GenerarNumerosAleatorios(3)}");

            return idUnico;
        }

        public int GenerarNumerosAleatorios(int digitos)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next((int)Math.Pow(10, digitos - 1), (int)Math.Pow(10, digitos));
            return numeroAleatorio;
        }
    }
}
