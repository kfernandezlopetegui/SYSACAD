using Actualizar;
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
    public partial class EditarCurso : Form, ITraerLista
    {
        
        public EditarCurso()
        {
            InitializeComponent();
            var logica = new TraerListaCursoLogica(this);

            OnListaPedida?.Invoke();
        }

        public event Action OnListaPedida;

        public void AsignarLista<T>(List<T> lista)
        {
            dataGridViewCursos.DataSource = lista;
            dataGridViewCursos.Columns["CupoActual"].Visible = false;
            dataGridViewCursos.Columns["Id"].Visible = false;
            dataGridViewCursos.Columns["IdRequisitos"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaDeCursos listaCursos = new ListaDeCursos();
            Menu.MostrarMenu(listaCursos, this, 1);
        }

        private void dataGridViewCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Curso cursoSeleccionado = (Curso)dataGridViewCursos.Rows[e.RowIndex].DataBoundItem;
            EdicionDeCurso edicionDeCurso = new EdicionDeCurso(cursoSeleccionado);
            Menu.MostrarMenu(edicionDeCurso, this, 1);
        }
    }
}
