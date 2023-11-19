using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerados;


namespace Entidades
{
    
    public class DescripcionSeleccionada
    {
        public List<DiaSemana> DiasSeleccionados { get; set; }
        public List<string> HorariosSeleccionados { get; set; }
        public string AulaSeleccionada { get; set; }

        public DescripcionSeleccionada(List<DiaSemana> diasSeleccionados, List<string> horariosSeleccionados, string aulaSeleccionada)
        {
            DiasSeleccionados = diasSeleccionados;
            HorariosSeleccionados = horariosSeleccionados;
            AulaSeleccionada = aulaSeleccionada;
        }

        public DescripcionSeleccionada()
        {
        }
    }
}
