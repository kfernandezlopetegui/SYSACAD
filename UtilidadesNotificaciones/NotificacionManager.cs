
using Entidades;
using Interfaces;
using LogicaSysacad;
using Login;
using Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilidadesNotificaciones
{
    public class NotificacionManager: ITraerListaNotificaciones, ITraerListaConceptos, IAgregarNotificacion
    {
        private Timer notificacionTimer;

        public event Action OnListaPedidaNotificacion;
        public event Action OnListaPedida;
        public event Action AgregarNotificacion;

        List<Notificacion> notificaciones;
        int idUsuario;
        public NotificacionManager()
        {
            // Configurar el temporizador para verificar y actualizar notificaciones cada 1 minuto
            
            idUsuario = ObtenerIdUsuarioActual();
            var logica = new TraerListaNotificacionesLogica(this, idUsuario);
            OnListaPedidaNotificacion?.Invoke();

            var logicaConceptos = new TraerListaConceptosLogica(this);
            notificacionTimer = new Timer(VerificarYActualizarNotificaciones, null, TimeSpan.Zero, TimeSpan.FromMinutes(1));
        }

        private void VerificarYActualizarNotificaciones(object state)
        {
            OnListaPedida.Invoke();
           
        }

        private void GenerarNotificaciones(List<ConceptoPagos> conceptos)
        {
            

            foreach (var concepto in conceptos)
            {
                Notificacion notificacion = concepto.GenerarNotificacion();

                if (notificacion != null)
                {
                    var logicaAgregar = new AgregarNotificacionLogica(this, notificacion);
                   AgregarNotificacion.Invoke();
                }
            }

        }

        

        private int ObtenerIdUsuarioActual()
        {
            return 94298161;
        }

        public void AsignarListaNotificacion(List<Notificacion> lista)
        {
            notificaciones = lista;
        }

        public void AsignarLista(List<ConceptoPagos> lista)
        {
            GenerarNotificaciones(lista);
        }
    }
}
