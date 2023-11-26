using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Semestre
    {
        public string Nombre { get; set; }
        public List<int> Meses { get; set; }
        

        public Semestre(string nombre, List<int> mesesPrimerSemestre)
        {
            Nombre = nombre;
            Meses = mesesPrimerSemestre;
            
        }
    }
}
