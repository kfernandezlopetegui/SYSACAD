using Entidades;
using Interfaces;
using LogicaSysacad;
using Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilidadesNotificaciones;

namespace New_SYSACAD
{
    public class EnviarNotificaciones: ITraerListaConceptos
    {
        public EnviarNotificaciones()
        {
            TraerListaConceptosLogica logica = new TraerListaConceptosLogica(this);
        }

        public event Action OnListaPedida;

        public static void EnviarNotificacionAlAlumno(string mensaje)
        {
            // Obtén la instancia de TuFormularioAlumno (puede ser a través de inyección de dependencias u otro método)
            Form formularioActivo = Application.OpenForms.OfType<MenuEstudiante>().FirstOrDefault();

            if (formularioActivo != null)
            {
                // Aquí puedes llamar a un método en el formulario para mostrar la notificación
                ((MenuEstudiante)formularioActivo).MostrarNotificacion(mensaje);
            }
        }

        public void AsignarLista(List<ConceptoPagos> lista)
        {
            RealizarSeguimientoConceptos(lista);
        }

        public void SeguimientoTimer_Tick(object sender, EventArgs e)
        {
            

            OnListaPedida.Invoke();
        }

        public static void RealizarSeguimientoConceptos(List<ConceptoPagos> conceptos)
        {


            foreach (var concepto in conceptos)
            {
                // Obtener el mensaje de seguimiento para cada concepto
                string mensajeSeguimiento = concepto.ObtenerMensajeSeguimiento();

                // Mostrar el mensaje de seguimiento al usuario (puedes usar MessageBox, notificaciones, etc.)
                EnviarNotificacionAlAlumno(mensajeSeguimiento);
            }


        }
        public static void RealizarSeguimientoConceptos(List<ConceptoPagos> conceptos, int idUsuarioDestino)
        {
            // Obtener las notificaciones destinadas al usuario específico
            List<Notificacion> notificacionesParaUsuario = ObtenerNotificacionesParaUsuario(idUsuarioDestino);

            foreach (var concepto in conceptos)
            {
                // Obtener el mensaje de seguimiento para cada concepto
                string mensajeSeguimiento = concepto.ObtenerMensajeSeguimiento();

                // Mostrar el mensaje de seguimiento al usuario (puedes usar MessageBox, notificaciones, etc.)
                EnviarNotificacionAlAlumno(mensajeSeguimiento);
            }
        }

        private static List<Notificacion> ObtenerNotificacionesParaUsuario(int idUsuario)
        {
            // Lógica para obtener notificaciones desde tu origen de datos (base de datos, lista en memoria, etc.)
            // Filtras las notificaciones basándote en el IdUsuarioDestino
            // ...

            // Ejemplo: Devuelve una lista ficticia para propósitos de demostración
            List<Notificacion> lista = new List<Notificacion>();
            return lista;
    
        }
    }
}
