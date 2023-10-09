using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecturaEscritura
{
    public class LegajoManager
    {
        
       

        public static int GenerarNuevoLegajo()
        {
            int ultimoNumeroLegajo;
            NumeroLegajo numeroLegajo = CargarUltimoNumeroLegajo();
            

            if (numeroLegajo!= null && numeroLegajo.Legajo!= -1 && numeroLegajo.Legajo!= 0)
            {
                ultimoNumeroLegajo = numeroLegajo.Legajo;
                ultimoNumeroLegajo++;
                
            }
            else
            {
                ultimoNumeroLegajo = 11110;
            }
            ActualizarUltimoNumeroLegajo(ultimoNumeroLegajo);

            return ultimoNumeroLegajo;
            
            

            
        }

        
        public static NumeroLegajo CargarUltimoNumeroLegajo()
        {
            NumeroLegajo ultimoLegajo = CRUD.ReadNumeroLegajoJSON("legajos.json");

            return ultimoLegajo;
        }

        
        private static void ActualizarUltimoNumeroLegajo(int nuevoValor)

        {
           
            NumeroLegajo numeroLegajoActualizar= new NumeroLegajo(nuevoValor);
           
            CRUD.WriteNumeroLegajoJSON("legajos.json", numeroLegajoActualizar);
        }
    }
}
