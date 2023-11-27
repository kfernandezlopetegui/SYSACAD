using System;
using Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using Entidades;

namespace LogicaSysacad
{
    public class VerificarSiHayNotificacionesNuevasLogica
    {
        IVerificarSiHayNotificacionesNuevas solicitud;
        private int idUsuario;

        public VerificarSiHayNotificacionesNuevasLogica(IVerificarSiHayNotificacionesNuevas solicitud, int idUsuario)
        {
            this.solicitud = solicitud;
            this.idUsuario = idUsuario;
            this.solicitud.VerificarSiHayNotificaciones += VerificarSiHayNotificaciones;
        }

        public async void VerificarSiHayNotificaciones()
        {
            List<Notificacion> listaNotificaciones = await CRUDB.ObtenerNotificacionesPorIdUsuarioAsync(idUsuario);
            
          
            solicitud.ValidarSiHayNotificaciones(listaNotificaciones.Any(notificacion => !notificacion.Leido));
        }
    }
}
