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
    public class TraerListaProfesoresLogica
    {
        private ITraerLista _solicitud;

        public TraerListaProfesoresLogica(ITraerLista solicitud)
        {
            _solicitud = solicitud;
            _solicitud = solicitud;
            solicitud.OnListaPedida += TraerListaProfesores;
        }

        public void TraerListaProfesores()
        {
            List<ProfesorConCurso> listaCursos = CRUDB.ObtenerDatosProfesores();
            _solicitud.AsignarLista(listaCursos);
        }
    }
}
