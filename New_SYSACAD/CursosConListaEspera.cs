using DB;
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
    public partial class CursosConListaEspera : Form, ITraerLista
    {
        public CursosConListaEspera()
        {
            InitializeComponent();
            var logica = new TraerListaCursosEsperaLogica(this);
            OnListaPedida?.Invoke();
        }

        public event Action OnListaPedida;

        public void AsignarLista<T>(List<T> lista)
        {
            dataGridViewCursos.AutoGenerateColumns = true;
            dataGridViewCursos.DataSource = lista;

            dataGridViewCursos.Columns["Nombre"].HeaderText = "Nombre del Curso";
            dataGridViewCursos.Columns["Id"].Visible = false;
            dataGridViewCursos.Columns["IdRequisitos"].Visible = false;
            dataGridViewCursos.Columns["CupoActual"].Visible = false;
            dataGridViewCursos.Columns["CupoMaximo"].Visible = false;
            foreach (DataGridViewColumn column in dataGridViewCursos.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            Menu.MostrarMenu(menuAdministrador, this, 1);
        }

        private void dataGridViewCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Curso cursoSeleccionado = (Curso)dataGridViewCursos.Rows[e.RowIndex].DataBoundItem;
            MostrarListaEsperaCurso listaEsperaCurso= new MostrarListaEsperaCurso(cursoSeleccionado);
            Menu.MostrarMenu(listaEsperaCurso, this, 1);
        }
    }
}
