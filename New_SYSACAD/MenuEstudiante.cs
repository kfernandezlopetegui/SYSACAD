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
    public partial class MenuEstudiante : Form
    {

        private Alumno alumno;
        private string nombreArchivoCursos = "cursosRegistrados.json";
        private string nombreArchivoInscripciones = "inscripcionesRegistradas.json";
        private List<ConceptoPagos> pagos = new List<ConceptoPagos>();
        private decimal montoPago = 100050;
        public MenuEstudiante(Alumno alumnoIngresado)
        {
            InitializeComponent();
            this.alumno = alumnoIngresado;
            SesionAlumno.IniciarSesion(alumno);

            labelBienvenida.Text = "Bienvenido, " + SesionAlumno.AlumnoActual.Nombre + "!";

            ConceptoPagos pagoUno = new ConceptoPagos(1000, "Libros");
            ConceptoPagos pagoDos = new ConceptoPagos(99000, "Matricula");
            ConceptoPagos pagoTres = new ConceptoPagos(50, "Materia");
            pagos.Add(pagoUno); pagos.Add(pagoDos); pagos.Add(pagoTres);
        }
        public MenuEstudiante()
        {
            InitializeComponent();
            labelBienvenida.Text = "Bienvenido, " + SesionAlumno.AlumnoActual.Nombre + "!";
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Form1 menuInicio = new Form1();
            Menu.MostrarMenu(menuInicio, this, 1);
        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            InscripcionCursos inscripcionCursos = new InscripcionCursos();
            Menu.MostrarMenu(inscripcionCursos, this, 1);
        }

        private void buttonHorarios_Click(object sender, EventArgs e)
        {
            List<Curso> listaDeCursos = ActualizarCurso.ObtenerCursosAlumno(nombreArchivoCursos, nombreArchivoInscripciones, SesionAlumno.AlumnoActual.Dni);
            if (listaDeCursos.Count > 0)
            {
                ConsultarHorario consultarHorario = new ConsultarHorario();
                Menu.MostrarMenu(consultarHorario, this, 1);
            }
            else
            {
                MessageBox.Show($"El horario se encuentra vacio, no te has inscripto a ningun curso",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonRealizarPagos_Click(object sender, EventArgs e)
        {
            MetodosDePago metodosDePago = new MetodosDePago(montoPago, pagos);
            Menu.MostrarMenu(metodosDePago, this, 1);
        }
    }
}
