using Actualizar;
using DB;
using Entidades;
using LecturaEscritura;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace New_SYSACAD
{
    public partial class RegistroAlumno : Form
    {
        private bool controlTocoFocoDni = false;
        private bool controlTocoFocoNombre = false;
        private bool controlTocoFocoApellido = false;
        private bool controlTocoFocoTelefono = false;
        private bool controlTocoFocoMail = false;
        private bool controlTocoFocoDireccion = false;
        private bool controlTocoFocoContraseñaP = false;
        private bool controlTocoFocoPalabraClave = false;

        private string textoPorDefectoNombre = "Ingrese nombre";
        private string textoPorDefectoApellido = "Ingrese apellido";
        private string textoPorDefectoTelefono = "Ingrese telefono";
        private string textoPorDefectoDireccion = "Ingrese direccion";
        private string textoPorDefectoContraseñaP = "Ingrese contraseña provisional";
        private string textoPorDefectoPalabraClave = "Ingrese palabra clave";


        public RegistroAlumno()
        {
            InitializeComponent();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdministrador menuAdministrador = new MenuAdministrador();

            Menu.MostrarMenu(menuAdministrador, this, 1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (controlTocoFocoDni && controlTocoFocoNombre && controlTocoFocoApellido && controlTocoFocoTelefono && controlTocoFocoMail && controlTocoFocoDireccion && controlTocoFocoContraseñaP && controlTocoFocoPalabraClave)
            {
                int dni = int.Parse(textDni.Text);
                string nombre = textNombre.Text;
                string apellido = textApellido.Text;
                string telefono = textTelefono.Text;
                string mail = textMail.Text;
                string direccion = textDireccion.Text;
                string contraseñaP = textContraseñaP.Text;
                string palabraClave = textPalabraClave.Text;
                string fechaNacimiento = FechaDeNacimiento.Value.Date.ToString("dd-MM-yyyy");
                bool temporal = checkBox1.Checked;
                contraseñaP = Hash.GetHash(contraseñaP);

                int legajo = DataBase.ObtenerUltimoLegajo();
                legajo++;

                Alumno alumno = new Alumno(nombre, apellido, "indefinido", mail, contraseñaP,
                    temporal, false, "estudiante", fechaNacimiento, palabraClave, legajo,
                    dni, direccion, telefono);

                ActualizarUsuarios.AgregarAlumnoBD("alumnosRegistrados.json", alumno);

                DialogResult resultado = MessageBox.Show("¡Registro exitoso! El alumno se ha registrado correctamente.",
                                             "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultado == DialogResult.OK)
                {
                    RestablecerFormulario();
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textDni_Enter(object sender, EventArgs e)
        {
            controlTocoFocoDni = true;
            textDni.Text = string.Empty;

        }

        private void textNombre_Enter(object sender, EventArgs e)
        {
            controlTocoFocoNombre = true;
            textNombre.Text = string.Empty;
        }

        private void textApellido_Enter(object sender, EventArgs e)
        {
            controlTocoFocoApellido = true;
            textApellido.Text = string.Empty;
        }

        private void textTelefono_Enter(object sender, EventArgs e)
        {
            controlTocoFocoTelefono = true;
            textTelefono.Text = string.Empty;
        }

        private void textMail_Enter(object sender, EventArgs e)
        {
            controlTocoFocoMail = true;
            textMail.Text = string.Empty;
        }

        private void textDireccion_Enter(object sender, EventArgs e)
        {
            controlTocoFocoDireccion = true;
            textDireccion.Text = string.Empty;
        }

        private void textContraseñaP_Enter(object sender, EventArgs e)
        {
            controlTocoFocoContraseñaP = true;
            textContraseñaP.Text = string.Empty;
        }

        private void textPalabraClave_Enter(object sender, EventArgs e)
        {
            controlTocoFocoPalabraClave = true;
            textPalabraClave.Text = string.Empty;
        }

        private void textMail_Validated(object sender, EventArgs e)
        {
            string correoElectronico = textMail.Text;


            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(patronCorreo);
            ValidarUsuario validarUsuario = new ValidarUsuario();

            if (regex.IsMatch(correoElectronico) && validarUsuario.VerificarSiExisteAlumnoBD(correoElectronico) == null)
            {

            }
            else
            {

                MessageBox.Show("La dirección de correo electrónico no es válida o ya se encuentra en el sistema. Por favor, ingresa una dirección válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textMail.Focus();
            }
        }

        private void textDni_Validated(object sender, EventArgs e)
        {
            string dni = textDni.Text;
            ValidarUsuario validarUsuario = new ValidarUsuario();


            if (!Regex.IsMatch(dni, @"^\d+$"))
            {
                MessageBox.Show("El DNI debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDni.Focus();
                return;
            }


            if (dni.Length < 7)
            {
                MessageBox.Show("El DNI debe tener al menos 7 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDni.Focus();
                return;
            }

            if (validarUsuario.VerificarSiExisteAlumnoBD(int.Parse(dni)) != null)
            {
                MessageBox.Show("El DNI ingresado ya se encuentra ingresado en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDni.Focus();
                return;
            }


        }





        private void textNombre_Validated(object sender, EventArgs e)
        {

            string textoCampo = "Nombre";
            ControlForm.ValidarCampoNoVacio(textNombre, textoCampo);
            ControlForm.ValidarCampoNoPorDefecto(textNombre, textoCampo, textoPorDefectoNombre);
        }

        private void textApellido_Validated(object sender, EventArgs e)
        {

            string textoCampo = "Apellido";
            ControlForm.ValidarCampoNoVacio(textApellido, textoCampo);
            ControlForm.ValidarCampoNoPorDefecto(textApellido, textoCampo, textoPorDefectoApellido);
        }

        private void textTelefono_Validated(object sender, EventArgs e)
        {

            string textoCampo = "Telefono";
            ControlForm.ValidarCampoNoVacio(textTelefono, textoCampo);
            ControlForm.ValidarCampoNoPorDefecto(textTelefono, textoCampo, textoPorDefectoTelefono);
        }

        private void textDireccion_Validated(object sender, EventArgs e)
        {

            string textoCampo = "Direccion";
            ControlForm.ValidarCampoNoVacio(textDireccion, textoCampo);
            ControlForm.ValidarCampoNoPorDefecto(textDireccion, textoCampo, textoPorDefectoDireccion);
        }

        private void textContraseñaP_Validated(object sender, EventArgs e)
        {

            string textoCampo = "Contraseña provisional";
            ControlForm.ValidarCampoNoVacio(textContraseñaP, textoCampo);
            ControlForm.ValidarCampoNoPorDefecto(textContraseñaP, textoCampo, textoPorDefectoContraseñaP);
        }

        private void textPalabraClave_Validated(object sender, EventArgs e)
        {

            string textoCampo = "Palabra clave";
            ControlForm.ValidarCampoNoVacio(textContraseñaP, textoCampo);
            ControlForm.ValidarCampoNoPorDefecto(textContraseñaP, textoCampo, textoPorDefectoPalabraClave);
        }

        private void FechaDeNacimiento_Validated(object sender, EventArgs e)
        {
            string fechaNacimiento = FechaDeNacimiento.Value.Date.ToString("dd-MM-yyyy");
            DateTime fechaHoy = DateTime.Now.Date;
            string fechaStringDefecto = fechaHoy.ToString("dd-MM-yyyy");
            string textoCampo = "Fecha de nacimiento";
            if (fechaNacimiento == fechaStringDefecto)
            {
                MessageBox.Show($"{textoCampo} no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return;
            }


        }

        

        private void RestablecerFormulario()
        {
            RegistroAlumno menuRegistro = new RegistroAlumno();

            Menu.MostrarMenu(menuRegistro, this, 1);
        }

       


    }
}
