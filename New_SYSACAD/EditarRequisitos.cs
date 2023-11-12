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
    public partial class EditarRequisitos : Form
    {
        List<CursoConRequisitos> cursosConRequisitos;
        public EditarRequisitos(List<CursoConRequisitos> cursosConRequisitos)
        {
            InitializeComponent();
            this.cursosConRequisitos = cursosConRequisitos;
            dataGridViewCursos.DataSource = this.cursosConRequisitos;
            dataGridViewCursos.Columns["IdCursosCorrelativos"].Visible = false;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            GestionarRequisitosAcademicos gestionarRequisitosAcademicos = new GestionarRequisitosAcademicos();
            Menu.MostrarMenu(gestionarRequisitosAcademicos, this, 1);
        }

        private void dataGridViewCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CursoConRequisitos cursoSeleccionado = (CursoConRequisitos)dataGridViewCursos.Rows[e.RowIndex].DataBoundItem;
           
            EdicionRequisito edicionDeRequisito = new EdicionRequisito(cursoSeleccionado);
            Menu.MostrarMenu(edicionDeRequisito, this, 1);
        }
    }
}
