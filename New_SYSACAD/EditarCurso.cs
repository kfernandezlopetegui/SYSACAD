using Actualizar;
using Entidades;
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
    public partial class EditarCurso : Form
    {
        List<Curso> listaCursos = ActualizarCurso.ListaCursosActualesBD();
        public EditarCurso()
        {
            InitializeComponent();
            dataGridViewCursos.DataSource = listaCursos;
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
