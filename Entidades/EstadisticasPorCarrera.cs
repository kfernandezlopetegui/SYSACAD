using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstadisticasPorCarrera
    {
        public string Carrera { get; set; }
        public int CantidadInscripciones { get; set; }

        public double PorcentajeInscripciones { get; set; }

        public EstadisticasPorCarrera(string carrera, int cantidadInscripciones, double porcentajeInscripciones)
        {
            Carrera = carrera;
            CantidadInscripciones = cantidadInscripciones;
            PorcentajeInscripciones = porcentajeInscripciones;
        }

        public EstadisticasPorCarrera()
        {
        }
    }
}
