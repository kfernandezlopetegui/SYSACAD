using Actualizar;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public class TraerListaAlumnosLogica
    {
        private ITraerLista _solicitud;
        public TraerListaAlumnosLogica(ITraerLista solicitud)
        {
            _solicitud = solicitud;
            solicitud.OnListaPedida += TraerListaCursos;
        }

        public void TraerListaCursos()
        {
            List<Alumno> listaCursos = ActualizarUsuarios.ListaAlumnosActuales();
            _solicitud.AsignarLista(listaCursos);
        }
    }
}
