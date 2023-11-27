using DB;
using Entidades;
using Interfaces;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public class AgregarNotificacionLogica
    {
        private IAgregarNotificacion solicitud;

        private Notificacion notificacion;

        public AgregarNotificacionLogica(IAgregarNotificacion solicitud, Notificacion notificacion)
        {
            this.solicitud = solicitud;
            this.notificacion = notificacion;
            this.solicitud.AgregarNotificacion += AgregarNotificacion;
        }

        public async void AgregarNotificacion()
        {
            int idNotificacion = DataBase.ObtenerUltimoIdNotificaciones();
            idNotificacion++;
            notificacion.Id = idNotificacion;
            string mensajeAComparar = notificacion.Mensaje;
            List<Notificacion> listaNotificaciones = await CRUDB.ObtenerNotificacionesPorIdUsuarioAsync(notificacion.IdUsuarioDestino);
            bool hayNotificacionConMismoMensaje = listaNotificaciones.Any(notificacion => notificacion.Mensaje == mensajeAComparar);
            if(!hayNotificacionConMismoMensaje)
            {
                await CRUDB.InsertarRegistroAsync<Notificacion>(notificacion);
            }
            
        }
    }
}
