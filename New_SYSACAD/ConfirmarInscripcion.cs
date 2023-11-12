using Actualizar;
using Entidades;
using Login;
using Pagos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;

namespace New_SYSACAD
{
    public partial class ConfirmarInscripcion : Form
    {
        HashSet<Curso> listaDeCursos;

        private string nombreArchivoCursos = "cursosRegistrados.json";
        private string nombreArchivoInscripciones = "inscripcionesRegistradas.json";
        
        
        public ConfirmarInscripcion(HashSet<Curso> listaCursos)
        {
            InitializeComponent();
            this.listaDeCursos = listaCursos;

            ConfigurarListView();
            MostrarCursosEnListView();

            
        }

        private void ConfigurarListView()
        {
            // Configurar las columnas del ListView
            listViewCursos.View = View.Details;
            listViewCursos.Columns.Add("Nombre", 150);
            listViewCursos.Columns.Add("Código", 100);
            listViewCursos.Columns.Add("Disponibilidad", 250);
        }

        private void MostrarCursosEnListView()
        {
            foreach (var curso in listaDeCursos)
            {
                string disponibilidad = ActualizarCurso.VerificarCupo(curso) ? "Cupo disponible" : "Sin cupo disponible";

                // Agregar un ListViewItem con las columnas necesarias
                ListViewItem item = new ListViewItem(curso.Nombre);
                item.SubItems.Add(curso.Codigo.ToString());
                item.SubItems.Add(disponibilidad);

                // Agregar el ListViewItem al ListView
                listViewCursos.Items.Add(item);
            }



        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            foreach (var curso in listaDeCursos)
            {
                RequisitosAcademicos requisitosCurso = ActualizarRequisitos.ObtenerRequisitos(curso.IdRequisitos);
                bool cumpleRequisitos = ValidarCurso.VerificarRequisitos(requisitosCurso, SesionAlumno.AlumnoActual.Dni);
                bool disponibilidad = ActualizarCurso.VerificarCupoOnline(curso);

                if (disponibilidad && cumpleRequisitos)
                {
                    ConceptoPagos conceptoPagos = new ConceptoPagos(10000,curso.Nombre);
                    Inscripcion inscripcion = new Inscripcion(SesionAlumno.AlumnoActual.Dni, curso.Codigo);
                    ActualizarInscripciones.AgregarInscripcion(inscripcion);
                    ActualizarUsuarios.AgregarPagosPendientes(conceptoPagos, SesionAlumno.AlumnoActual.Dni);

                    ActualizarCurso.ActualizarCupo("cursosRegistrados.json", curso.Codigo);

                    // Mostrar mensaje de éxito
                    MessageBox.Show($"Te has inscripto correctamente a {curso.Nombre}.",
                                              "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (cumpleRequisitos ==false)
                    {
                        MessageBox.Show($"No se cumplen todos los requisitos para poder inscribirse a {curso.Nombre}.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if(disponibilidad == false)
                    {
                        MessageBox.Show($"No hay cupo disponible para el curso {curso.Nombre}. No se pudo inscribir",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            InscripcionCursos inscripcionCursos = new InscripcionCursos();
            Menu.MostrarMenu(inscripcionCursos, this, 1);


        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            MenuEstudiante menuEstudiante = new MenuEstudiante();
            Menu.MostrarMenu(menuEstudiante, this, 1);
        }

        
    }
}
