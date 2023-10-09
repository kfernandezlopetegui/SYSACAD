using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroLegajo

    {
        public int Legajo { get; set; }

        public NumeroLegajo() // Constructor sin parámetros necesario para deserialización
        {
        }

        public NumeroLegajo(int legajo)
        {
            Legajo = legajo;
        }

    }
}
