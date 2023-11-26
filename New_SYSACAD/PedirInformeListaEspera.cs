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
    public partial class PedirInformeListaEspera : Form, ITraerListaCurso, IPedirInforme
    {
        
        public PedirInformeListaEspera()
        {
            InitializeComponent();
            var logica = new TraerListaCursoLogica(this);
            OnListaPedida?.Invoke();
        }

        public event Action OnListaPedida;
        public event Action OnPedirInforme;

        public void AsignarLista(List<Curso> lista)
        {
            comboBoxCurso.DisplayMember = "Nombre";
            comboBoxCurso.ValueMember = "Codigo";
            comboBoxCurso.DataSource = lista;
        }

        public void MensajeError()
        {
            MessageBox.Show("No hay informe para mostrar en el curso seleccionado.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            InformesDisponibles informesDisponibles = new InformesDisponibles();
            Menu.MostrarMenu(informesDisponibles, this, 1);
        }

        private void buttonInformePDf_Click(object sender, EventArgs e)
        {
           
            Curso cursoSeleccionado = (Curso)comboBoxCurso.SelectedItem;
            var logicaInforme = new InformeListaEsperaLogica(this,cursoSeleccionado);

            OnPedirInforme.Invoke();
            
                PedirInformeListaEspera pedirInformeEspera = new PedirInformeListaEspera();
                Menu.MostrarMenu(pedirInformeEspera, this, 1);
            
            
        }
    }
}
