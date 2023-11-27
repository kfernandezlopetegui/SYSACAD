using DB;
using Entidades;
using Interfaces;
using Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public class TraerListaConceptosLogica
    {
        private ITraerListaConceptos _solicitud;

        public TraerListaConceptosLogica(ITraerListaConceptos solicitud)
        {
            _solicitud = solicitud;
            _solicitud.OnListaPedida += TraerListaConceptos;
        }

        public void TraerListaConceptos()
        {
            List<ConceptoPagos> lista  = CRUDB.ObtenerTodos<ConceptoPagos>("ConceptoPagos");
            _solicitud.AsignarLista(lista);
        }
    }
}
