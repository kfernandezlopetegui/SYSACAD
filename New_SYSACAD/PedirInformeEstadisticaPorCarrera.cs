using DocumentFormat.OpenXml.Drawing.Charts;
using Entidades;
using Interfaces;
using LogicaSysacad;
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
    public partial class PedirInformeEstadisticaPorCarrera : Form, ITraerLista, IPedirInforme
    {
        public PedirInformeEstadisticaPorCarrera()
        {
            InitializeComponent();
            var logica = new TraerPeriodosLogica(this);
            OnListaPedida?.Invoke();
        }

        public event Action OnListaPedida;
        public event Action OnPedirInforme;

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            InformesDisponibles informes = new InformesDisponibles();
            Menu.MostrarMenu(informes, this, 1);

        }

        private void buttonInformePDf_Click(object sender, EventArgs e)
        {
            Periodo periodoSeleccionado = (Periodo)comboBoxPeriodo.SelectedItem;
            var logicaInforme = new InformeEstadisticasInscripcionPorCarreraLogica(this, periodoSeleccionado);
            OnPedirInforme.Invoke();
            PedirInformeEstadisticaPorCarrera pedirInformeEstadistica = new PedirInformeEstadisticaPorCarrera();
            Menu.MostrarMenu(pedirInformeEstadistica, this, 1);
        }

        public void AsignarLista<T>(List<T> lista)
        {
            comboBoxPeriodo.DisplayMember = "Nombre";
            
            comboBoxPeriodo.DataSource = lista;
        }

        public void MensajeError()
        {
            MessageBox.Show("No hay informe para mostrar en el periodo ingresado.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
