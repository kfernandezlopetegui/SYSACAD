using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NotificacionEventArgs: EventArgs
    {
        public string Mensaje { get; }

        public NotificacionEventArgs(string mensaje)
        {
            Mensaje = mensaje;
        }
    }
}
