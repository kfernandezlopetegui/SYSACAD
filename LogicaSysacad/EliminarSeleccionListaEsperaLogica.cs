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
    public class EliminarSeleccionListaEsperaLogica
    {
        private IEliminarEleccionLE _solicitud;
        private SolicitudListaEsperaDetallada _eleccionAEliminar;
        public EliminarSeleccionListaEsperaLogica(IEliminarEleccionLE solicitud, SolicitudListaEsperaDetallada eleccionAEliminar)
        {
            _solicitud = solicitud;
            _eleccionAEliminar = eleccionAEliminar;
            _solicitud.EliminarEleccion += EliminarEleccion;
        }

        public async void EliminarEleccion()
        {
            await CRUDB.EliminarPorCondicionAsync<Curso>("ListaEspera", "Id", _eleccionAEliminar.IdSolicitud);
        }
    }
}
