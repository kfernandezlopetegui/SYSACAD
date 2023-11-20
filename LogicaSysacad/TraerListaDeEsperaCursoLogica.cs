using DB;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public class TraerListaDeEsperaCursoLogica
    {
        private ITraerLista _solicitud;
        private string _idCurso;
        public TraerListaDeEsperaCursoLogica(ITraerLista solicitud, string idCurso)
        {
            _solicitud = solicitud;
            solicitud.OnListaPedida += TraerListaEspera;
            _idCurso = idCurso;
        }

        public void TraerListaEspera()
        {
            List<SolicitudListaEsperaDetallada> listaCursos = CRUDB.ObtenerSolicitudesPorIdCurso(_idCurso);
            _solicitud.AsignarLista(listaCursos);
        }
    }
}
