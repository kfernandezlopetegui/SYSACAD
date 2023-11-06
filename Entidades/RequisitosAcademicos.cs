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

        
        
        public string IdCursosAprobadosJson { get; set; }
        public int CantidadMinimaCreditos { get; set; }
        public double PromedioMinimo { get; set; }

        [PrimaryKeyAtributo]
        public int Id {  get; set; }

       
        public RequisitosAcademicos(string idCursosAprobados, int cantidadMinimaCreditos, double promedioMinimo)
        {
            IdCursosAprobadosJson = idCursosAprobados;
            CantidadMinimaCreditos = cantidadMinimaCreditos;
            PromedioMinimo = promedioMinimo;
            Id = GenerarIdUnico();
        }

       
       

        public int GenerarIdUnico()
        {
            DateTime now = DateTime.Now;
            int idUnico = int.Parse($"{now:yyMMddHHmmss}");
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
