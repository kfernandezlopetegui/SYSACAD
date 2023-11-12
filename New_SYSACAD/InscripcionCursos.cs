using Actualizar;
using Entidades;
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
    public partial class InscripcionCursos : Form
    {
        private List<Curso> listaCursos = ActualizarCurso.ListaCursosActualesBD();

        private HashSet<Curso> cursosSeleccionados = new HashSet<Curso>();
        public InscripcionCursos()
        {
            InitializeComponent();
            dataGridViewCursos.DataSource = listaCursos;
            dataGridViewCursos.Columns["CupoActual"].Visible = false;
            dataGridViewCursos.Columns["CupoMaximo"].Visible = false;
            dataGridViewCursos.Columns["Id"].Visible = false;
            dataGridViewCursos.Columns["IdRequisitos"].Visible = false;
            dataGridViewCursos.MultiSelect = true;
            dataGridViewCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            labelIndicaciones.Text = "Por favor selecciona los cursos a los que deseas inscribirte , " + SesionAlumno.AlumnoActual.Nombre;
           
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            MenuEstudiante menuEstudiante = new MenuEstudiante();
            Menu.MostrarMenu(menuEstudiante, this, 1);
        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            cursosSeleccionados.Clear(); // Limpiar la lista antes de agregar los cursos seleccionados

            foreach (DataGridViewRow row in dataGridViewCursos.SelectedRows)
            {
                // Obtener el objeto Curso de la fila actual
                Curso cursoSeleccionado = (Curso)row.DataBoundItem; // Obtén el objeto Curso de la fila actual

                // Agregar el curso al conjunto de cursos seleccionados
                cursosSeleccionados.Add(cursoSeleccionado);
            }
            ConfirmarInscripcion confirmarInscripcion = new ConfirmarInscripcion(cursosSeleccionados);
            Menu.MostrarMenu(confirmarInscripcion, this, 1);
        }
    }
}
