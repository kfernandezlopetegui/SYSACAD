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

namespace New_SYSACAD
{
    public partial class AgregarProfesor : Form
    {
        private int textBoxModificados = 0;
        public AgregarProfesor()
        {
            InitializeComponent();
            AsociarEventoTextChanged(this);
        }

        private async void textEmail_Validated(object sender, EventArgs e)
        {
            string correoElectronico = textEmail.Text;


            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(patronCorreo);
            ValidarUsuario validarUsuario = new ValidarUsuario();

            if (!regex.IsMatch(correoElectronico))
            {
                MessageBox.Show("La dirección de correo electrónico no es válida. Por favor, ingresa una dirección válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textEmail.Focus();
            }
            if (await validarUsuario.VerificarSiExisteProfesorBD(correoElectronico) != null)
            {
                MessageBox.Show("La dirección de correo electrónico ya se encuentra en el sistema. Por favor, ingresa otra dirección válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textEmail.Focus();
            }
        }

        private async void textDni_Validated(object sender, EventArgs e)
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

            if (dni.Length >10)
            {
                MessageBox.Show("El DNI debe tener menos de 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDni.Focus();
                return;
            }

            if (await validarUsuario.VerificarSiExisteProfesorBD(int.Parse(dni)) != null)
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

        }

        private void textApellido_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Apellido";
            ControlForm.ValidarCampoNoVacio(textApellido, textoCampo);
        }

        private void textBoxContraseña_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Contraseña provisional";
            ControlForm.ValidarCampoNoVacio(textBoxContraseña, textoCampo);
        }

        private void textBoxDireccion_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Domicilio";
            ControlForm.ValidarCampoNoVacio(textBoxDireccion, textoCampo);
        }

        private void textBoxNumeroTel_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Numero de Telefono";
            ControlForm.ValidarCampoNoVacio(textBoxNumeroTel, textoCampo);
        }

        private void textBoxPalabraClave_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Palabra clave";
            ControlForm.ValidarCampoNoVacio(textBoxPalabraClave, textoCampo);
        }

        private void textBoxAreasEspecializacion_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Areas de Especializacion";
            ControlForm.ValidarCampoNoVacio(textBoxAreasEspecializacion, textoCampo);
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
        private void AsociarEventoTextChanged(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).TextChanged += TextBox_TextChanged;
                }
                else if (c.HasChildren)
                {
                    AsociarEventoTextChanged(c);
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Incrementar el contador cada vez que un TextBox se modifica
            textBoxModificados++;
        }

        private int ContarTextBoxes(Control control)
        {
            int count = 0;
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    count++;
                }
                else if (c.HasChildren)
                {
                    count += ContarTextBoxes(c);
                }
            }
            return count;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            int totalTextBoxes = ContarTextBoxes(this);

            if (textBoxModificados == totalTextBoxes)
            {
                // Todos los TextBox fueron modificados
                // Realizar la lógica de guardar
            }
            else
            {
                MessageBox.Show($"No se realizaron cambios en todos los TextBox.{textBoxModificados}");
            }
        }
    }
}
