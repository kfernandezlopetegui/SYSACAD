using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITraerProfesor
    {
        public event Action OnProfesorPedido;
        public void CargarDatos(Profesor profe);
    }
}
