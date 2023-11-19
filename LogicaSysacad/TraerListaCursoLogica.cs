using Actualizar;
using Entidades;
using Interfaces;

namespace LogicaSysacad
{
    public class TraerListaCursoLogica
    {
        private ITraerLista _solicitud;

        public TraerListaCursoLogica(ITraerLista solicitud)
        {
            _solicitud = solicitud;
            solicitud.OnListaPedida += TraerListaCursos;
        }

        public void TraerListaCursos()
        {
              List<Curso> listaCursos = ActualizarCurso.ListaCursosActualesBD();
            _solicitud.AsignarLista(listaCursos);
        }
    }
}
