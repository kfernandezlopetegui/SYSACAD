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
    public class PedirInformePeriodoInscripcionesLogica
    {
        IPedirInforme solicitud;
        Periodo periodo;

        public PedirInformePeriodoInscripcionesLogica(IPedirInforme solicitud, Periodo periodo)
        {
            this.solicitud = solicitud;
            this.periodo = periodo;
            this.solicitud.OnPedirInforme += TraerInformePdf;
        }
        public void TraerInformePdf()
        {
            PDFInscripcionesPorPeriodo.CreatePdf(CRUDB.ObtenerInscripcionesEnPeriodo(periodo), periodo);
        }
    }
}
