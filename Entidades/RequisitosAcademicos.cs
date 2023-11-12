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
            Id = Ids.GenerarIdUnico();
        }

       
       

       

    }
}
