using Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITraerListaConceptos
    {
        public void AsignarLista(List<ConceptoPagos> lista);
        public  event Action OnListaPedida;
    }
}
