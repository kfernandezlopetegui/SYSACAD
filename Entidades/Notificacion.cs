using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Notificacion
    {
        public Notificacion()
        {
        }

        public int Id { get; set; }
        public int IdUsuarioDestino { get; set; }
        public string Mensaje { get; set; }
        public bool Leido { get; set; }

        public Notificacion(int id, int idUsuarioDestino, string mensaje, bool leido)
        {
            Id = id;
            IdUsuarioDestino = idUsuarioDestino;
            Mensaje = mensaje;
            Leido = leido;
        }
    }
}
