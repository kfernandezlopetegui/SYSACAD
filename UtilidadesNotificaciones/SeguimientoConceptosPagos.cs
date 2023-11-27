using Entidades;
using Interfaces;
using LogicaSysacad;
using Pagos;

namespace UtilidadesNotificaciones
{
    public  class SeguimientoConceptosPagos: ITraerListaConceptos
    {
        public  event Action OnListaPedida;
        

        public SeguimientoConceptosPagos()
        {
            TraerListaConceptosLogica logica = new TraerListaConceptosLogica(this);
        }

        public  void SeguimientoTimer_Tick(object sender, EventArgs e)
        {
            // Realizar el seguimiento y mostrar notificaciones
           
            OnListaPedida.Invoke();
        }

        public static void RealizarSeguimientoConceptos(List<ConceptoPagos> conceptos)
        {
            

            foreach (var concepto in conceptos)
            {
                // Obtener el mensaje de seguimiento para cada concepto
                string mensajeSeguimiento = concepto.ObtenerMensajeSeguimiento();

                // Mostrar el mensaje de seguimiento al usuario (puedes usar MessageBox, notificaciones, etc.)
               
            }

            
        }

        

        public void AsignarLista(List<ConceptoPagos> lista)
        {
            RealizarSeguimientoConceptos(lista);
        }

        
    }
}
