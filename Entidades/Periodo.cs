using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Periodo
    {
       
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public Periodo() { }

        public Periodo(DateTime inicio, DateTime fin)
        {
            Inicio = inicio;
            Fin = fin;
            
        }

        /// <summary>
        /// Verifica si hay coincidencia entre dos periodos
        /// </summary>
        /// <param name="otroPeriodo"></param>
        /// <returns></returns>
        public bool CoincideCon(Periodo otroPeriodo)
        {
            
            if ((otroPeriodo.Inicio >= Inicio && otroPeriodo.Inicio <= Fin) ||
                (otroPeriodo.Fin >= Inicio && otroPeriodo.Fin <= Fin))
            {
                return true; 
            }

            
            return false;
        }

        public static bool operator ==(Periodo periodo1, Periodo periodo2)
        {
            
            if (ReferenceEquals(periodo1, null) && ReferenceEquals(periodo2, null))
            {
                return true;
            }
            
            if (ReferenceEquals(periodo1, null) || ReferenceEquals(periodo2, null))
            {
                return false;
            }
            return periodo1.Inicio == periodo2.Inicio && periodo1.Fin == periodo2.Fin;
        }

        public static bool operator !=(Periodo periodo1, Periodo periodo2)
        {
            return !(periodo1 == periodo2);
        }

       
        public override bool Equals(object obj)
        {
            if (obj is Periodo)
            {
                return this == (Periodo)obj;
            }
            return false;
        }

        
        public override int GetHashCode()
        {
            return Inicio.GetHashCode() ^ Fin.GetHashCode();
        }
    }
}
