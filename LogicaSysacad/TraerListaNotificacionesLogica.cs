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
    public class TraerListaNotificacionesLogica
    {
        ITraerListaNotificaciones solicitud;
        int idUsuario;

        public TraerListaNotificacionesLogica(ITraerListaNotificaciones solicitud, int idUsuario)
        {
            this.solicitud = solicitud;
            this.idUsuario = idUsuario;
            this.solicitud.OnListaPedidaNotificacion += ObtenerNotificacionesPorIdUsuario;
        }
        private async void ObtenerNotificacionesPorIdUsuario()
        {
            List<Notificacion> listaNotificaciones = await CRUDB.ObtenerNotificacionesPorIdUsuarioAsync(idUsuario);
            solicitud.AsignarListaNotificacion(listaNotificaciones);
        }
    }
}
