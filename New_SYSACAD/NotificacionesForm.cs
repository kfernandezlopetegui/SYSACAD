using Entidades;
using Interfaces;
using LogicaSysacad;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_SYSACAD
{
    public partial class NotificacionesForm : Form, ITraerListaNotificaciones, IActualizarNotificacion
    {
        private int idUsuario = SesionAlumno.AlumnoActual.Dni;
        public NotificacionesForm()
        {
            InitializeComponent();
            var logica = new TraerListaNotificacionesLogica(this, idUsuario);
            OnListaPedidaNotificacion?.Invoke();

            var logicaActualizacionNotificaciones = new ActualizarNotificacionesLogica(this, idUsuario);
        }

        public event Action OnListaPedidaNotificacion;
        public event Action ActualizarNotificacion;

        public void AsignarListaNotificacion(List<Notificacion> lista)
        {
            listViewNotificaciones.View = View.Details;
            listViewNotificaciones.Columns.Add("Mensaje", 600);

            listViewNotificacionesLeidos.View = View.Details;
            listViewNotificacionesLeidos.Columns.Add("Mensaje", 600);
            
            if (lista.Count > 0)
            {
                listViewNotificaciones.Columns.Add("Leído", 80);
                listViewNotificacionesLeidos.Columns.Add("Leído", 80);

                foreach (var notificacion in lista)
                {
                    ListViewItem item = new ListViewItem(notificacion.Mensaje);
                    item.SubItems.Add(notificacion.Leido ? "Sí" : "No");

                    // Puedes personalizar más la apariencia o agregar información adicional según tus necesidades

                    if (notificacion.Leido)
                    {
                        listViewNotificacionesLeidos.Items.Add(item);
                    }
                    else
                    {
                        listViewNotificaciones.Items.Add(item);
                    }
                }
            }
            else
            {
                ListViewItem item = new ListViewItem("No hay notificaciones para mostrar");
                ListViewItem item2 = new ListViewItem("No hay notificaciones para mostrar");
                listViewNotificaciones.Items.Add(item);

                listViewNotificacionesLeidos.Items.Add(item2);
            }

        }

        private void listViewNotificaciones_MouseClick(object sender, MouseEventArgs e)
        {
            ActualizarNotificacion.Invoke();

        }

       
    }
}
