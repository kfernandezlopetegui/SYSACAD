using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITraerListaCurso
    {
        public void AsignarLista(List<Curso> lista);
        public event Action OnListaPedida;
    }
}
