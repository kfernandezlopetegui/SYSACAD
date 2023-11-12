using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Periodo
    {
        
        public int Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public Periodo() { }

        public Periodo(DateTime inicio, DateTime fin)
        {
            Inicio = inicio;
            Fin = fin;
            this.Id = Ids.GenerarIdUnico();
        }

        /// <summary>
        /// Verifica si hay coincidencia entre dos periodos
        /// </summary>
        /// <param name="otroPeriodo"></param>
        /// <returns></returns>
        public bool CoincideCon(Periodo otroPeriodo)
        {
            // Si el inicio del periodo dado está dentro de este periodo O
            // el fin del periodo dado está dentro de este periodo
            if ((otroPeriodo.Inicio >= Inicio && otroPeriodo.Inicio <= Fin) ||
                (otroPeriodo.Fin >= Inicio && otroPeriodo.Fin <= Fin))
            {
                return true; // Hay una coincidencia
            }

            // Si no hay ninguna coincidencia
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

        // Sobrecarga del método Equals para comparar dos objetos Periodo
        public override bool Equals(object obj)
        {
            if (obj is Periodo)
            {
                return this == (Periodo)obj;
            }
            return false;
        }

        // Sobrecarga del método GetHashCode para garantizar consistencia con Equals
        public override int GetHashCode()
        {
            return Inicio.GetHashCode() ^ Fin.GetHashCode();
        }
    }
}
