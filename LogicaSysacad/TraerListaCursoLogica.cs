using Actualizar;
using Entidades;
using Interfaces;

namespace LogicaSysacad
{
    public class TraerListaCursoLogica
    {
        private ITraerLista _solicitud;
        private ITraerListaCurso _solicitud2;

        public TraerListaCursoLogica(ITraerLista solicitud)
        {
            _solicitud = solicitud;
            solicitud.OnListaPedida += TraerListaCursos;
        }

        public TraerListaCursoLogica(ITraerListaCurso solicitud)
        {
            _solicitud2 = solicitud;
            solicitud.OnListaPedida += TraerListaCurso;
        }

        public void TraerListaCursos()
        {
              List<Curso> listaCursos = ActualizarCurso.ListaCursosActualesBD();
            _solicitud.AsignarLista(listaCursos);
        }

        public void TraerListaCurso()
        {
            List<Curso> listaCursos = ActualizarCurso.ListaCursosActualesBD();
            _solicitud2.AsignarLista(listaCursos);
        }
    }
}
