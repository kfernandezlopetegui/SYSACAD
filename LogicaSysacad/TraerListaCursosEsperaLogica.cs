using Actualizar;
using DB;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public class TraerListaCursosEsperaLogica
    {
        private ITraerLista _solicitud;
        public TraerListaCursosEsperaLogica(ITraerLista solicitud)
        {
            _solicitud = solicitud;
            solicitud.OnListaPedida += TraerListaCursosEspera;
        }

        public void TraerListaCursosEspera()
        {
            List<Curso> listaCursos = CRUDB.ObtenerCursosConListaEspera();
            _solicitud.AsignarLista(listaCursos);
        }
    }
}
