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


    public partial class ConsultarHorario : Form
    {

        private string nombreArchivoCursos = "cursosRegistrados.json";
        private string nombreArchivoInscripciones = "inscripcionesRegistradas.json";
        private List<Curso> listaDeCursos;
        public ConsultarHorario()
        {
            InitializeComponent();
            listaDeCursos = ActualizarCurso.ObtenerCursosAlumno( SesionAlumno.AlumnoActual.Dni);

            labelIndicaciones.Text = $"Horarios de {SesionAlumno.AlumnoActual.Apellido} {SesionAlumno.AlumnoActual.Nombre}";
            ConfigurarDataGridView();


        }

        private void ConfigurarDataGridView()
        {
            if (listaDeCursos != null)
            {
                // Configurar las columnas del ListView
                dataGridViewHorarios.Columns.Add("Materia", "Materia");
                dataGridViewHorarios.Columns.Add("Dias", "Dias de cursada");
                dataGridViewHorarios.Columns.Add("Horario", "Horario");
                dataGridViewHorarios.Columns.Add("Aula", "Aula");


                MostrarHorariosEnDataGridView();



            }

        }



        private void MostrarHorariosEnDataGridView()
        {


            foreach (var curso in listaDeCursos)
            {

                string dias = DescripcionCurso.ObtenerDias(curso.Descripcion);
                string horarios = DescripcionCurso.ObtenerHorarios(curso.Descripcion);
                string aulas = DescripcionCurso.ObtenerAula(curso.Descripcion);

                dataGridViewHorarios.Rows.Add(curso.Nombre, dias, horarios, aulas);

            }

        }
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            MenuEstudiante menuEstudiante = new MenuEstudiante();
            Menu.MostrarMenu(menuEstudiante, this, 1);
        }

        private void dataGridViewHorarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el valor de la celda
                object valor = dataGridViewHorarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Verificar si el valor no es nulo y contiene saltos de línea
                if (valor != null && valor.ToString().Contains(Environment.NewLine))
                {
                    // Reemplazar los saltos de línea con un espacio en blanco
                    e.Value = valor.ToString().Replace(Environment.NewLine, " y ");
                }
            }
        }

        
    }
}
