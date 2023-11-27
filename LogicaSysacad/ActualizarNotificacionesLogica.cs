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
    public class ActualizarNotificacionesLogica
    {
        private IActualizarNotificacion solicitud;
        private int idUsuario;

        public ActualizarNotificacionesLogica(IActualizarNotificacion solicitud, int idUsuario)
        {
            this.solicitud = solicitud;
            this.idUsuario = idUsuario;
            this.solicitud.ActualizarNotificacion += ActualizarNotificaciones;

        }
        public async void ActualizarNotificaciones()
        {
            List<Notificacion> listaNotificaciones = await CRUDB.ObtenerNotificacionesPorIdUsuarioAsync(idUsuario);
            await CRUDB.EliminarPorCondicionAsync<Notificacion>("Notificacion", "IdUsuarioDestino", idUsuario);
            foreach (var notificacion in listaNotificaciones)

            {   if (notificacion.Leido == false)
                {
                    notificacion.Leido = true;
                    
                }
                await CRUDB.InsertarRegistroAsync(notificacion);



            }
        }
    }
}
