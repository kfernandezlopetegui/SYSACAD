using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuatrimestre
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }

        public Cuatrimestre(string nombre, int numero)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}
