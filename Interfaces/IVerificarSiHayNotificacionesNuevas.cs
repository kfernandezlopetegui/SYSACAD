using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IVerificarSiHayNotificacionesNuevas
    {
        public event Action VerificarSiHayNotificaciones;
        public void ValidarSiHayNotificaciones(bool resultado);
    }
}
