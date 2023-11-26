using DB;
using Entidades;
using Interfaces;
using PDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public class InformeListaEsperaLogica
    {
        IPedirInforme solicitud;
        Curso cursoSeleccionado;

        public InformeListaEsperaLogica(IPedirInforme solicitud, Curso cursoSeleccionado)
        {
            this.solicitud = solicitud;
            this.cursoSeleccionado = cursoSeleccionado;
            this.solicitud.OnPedirInforme += InformePDF;
        }

        public void InformePDF()
        {
            List<SolicitudListaEsperaDetallada> solicitudesListaEspera = CRUDB.ObtenerSolicitudesPorIdCurso(cursoSeleccionado.Codigo);
            
            if (solicitudesListaEspera == null || solicitudesListaEspera.Count == 0)
            {
                solicitud.MensajeError(); 
            }
            else
            {
                PDFListaEspera.CreatePdf(solicitudesListaEspera, cursoSeleccionado);
            }
        }
    }
}
