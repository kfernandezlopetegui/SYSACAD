using Actualizar;
using Entidades;
using Interfaces;
using LogicaSysacad;
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

    public partial class MenuEstudiante : Form, IVerificarSiHayNotificacionesNuevas
    {
        public delegate void NotificacionEventHandler(object sender, NotificacionEventArgs e);


        private Alumno alumno;
        public event NotificacionEventHandler NotificacionRecibida;
        public event Action VerificarSiHayNotificaciones;

        public MenuEstudiante(Alumno alumnoIngresado)
        {
            InitializeComponent();
            this.alumno = alumnoIngresado;
            SesionAlumno.IniciarSesion(alumno);
            var logicaVerificar = new VerificarSiHayNotificacionesNuevasLogica(this, SesionAlumno.AlumnoActual.Dni);


            labelBienvenida.Text = "Bienvenido, " + SesionAlumno.AlumnoActual.Nombre + "!";

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
            List<Curso> listaDeCursos = ActualizarCurso.ObtenerCursosAlumno(SesionAlumno.AlumnoActual.Dni);
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
            //MetodosDePago metodosDePago = new MetodosDePago(montoPago, pagos);
            //Menu.MostrarMenu(metodosDePago, this, 1);
            FormPagosPendientes pagosPendientes = new FormPagosPendientes();
            Menu.MostrarMenu(pagosPendientes, this, 1);
        }

        public void MostrarNotificacion(string mensaje)
        {
            // Puedes usar un MessageBox u otra lógica para mostrar la notificación
            MessageBox.Show(mensaje, "Notificación para el Alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonNotificacion_Click(object sender, EventArgs e)
        {
            NotificacionesForm notificacionesForm = new NotificacionesForm();
            notificacionesForm.ShowDialog();
        }

        private void MenuEstudiante_MouseMove(object sender, MouseEventArgs e)
        {
            VerificarSiHayNotificaciones?.Invoke();
        }

        public void ValidarSiHayNotificaciones(bool resultado)
        {
            buttonNotificacion.BackgroundImageLayout = ImageLayout.Stretch;
            if (resultado)
            {
                // Cambia la imagen del botón si hay notificaciones sin leer
                buttonNotificacion2.Hide();
                buttonNotificacion2.Enabled = false;
                buttonNotificacion.Visible = true;
                buttonNotificacion.Enabled = true;
            }
            else
            {
                // Cambia la imagen del botón si todas las notificaciones están leídas
                buttonNotificacion.Hide();
                buttonNotificacion.Enabled = false;
                buttonNotificacion2.Visible = true;
                buttonNotificacion2.Enabled = true;
            }


        }

        private void buttonNotificacion2_Click(object sender, EventArgs e)
        {
            NotificacionesForm notificacionesForm = new NotificacionesForm();
            notificacionesForm.ShowDialog();

        }
    }
}
