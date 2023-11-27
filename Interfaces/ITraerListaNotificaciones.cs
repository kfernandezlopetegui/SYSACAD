using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITraerListaNotificaciones
    {
        public void AsignarListaNotificacion(List<Notificacion> lista);
        public event Action OnListaPedidaNotificacion;
    }
}
