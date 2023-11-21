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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace New_SYSACAD
{
    public partial class AgregarProfesor : Form, ITraerListaCurso, IAsignarCursos, IAgregarProfesor
    {
        private bool controlFocoFecha = false;

        public event Action OnListaPedida;
        public event Action AsignarCursos;
        public event Action AgregarProfe;

        public AgregarProfesor()
        {
            InitializeComponent();
            var logica = new TraerListaCursoLogica(this);

            OnListaPedida?.Invoke();

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

            if (dni.Length > 10)
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

        private void buttonAgregar_Click(object sender, EventArgs e)
        {


            if (TodosLosTextBoxNoEstanVacios(this) && controlFocoFecha)
            {
                int dni = int.Parse(textDni.Text);
                string nombre = textNombre.Text;
                string apellido = textApellido.Text;
                string telefono = textBoxNumeroTel.Text;
                string mail = textEmail.Text;
                string direccion = textBoxDireccion.Text;
                string contraseñaP = textBoxContraseña.Text;
                string palabraClave = textBoxPalabraClave.Text;
                string fechaNacimiento = FechaDeNacimiento.Value.Date.ToString("dd-MM-yyyy");
                string areasEspecializacion = textBoxAreasEspecializacion.Text;
                contraseñaP = Hash.GetHash(contraseñaP);

                var agregarProfe = new AgregarProfesorLogica(this, dni, nombre, apellido,
                    telefono, mail, direccion, contraseñaP, palabraClave, fechaNacimiento,
                     areasEspecializacion);

                AgregarProfe.Invoke();


                List<string> listaCursosAsignados = obtenerCursosSeleccionados();

                var logicaAsignarCursos = new AgregarCursosAsignadosLogica(this, dni, listaCursosAsignados);

                AsignarCursos.Invoke();

                DialogResult resultado = MessageBox.Show("¡Registro exitoso! El Profesor se ha registrado correctamente.",
                                             "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultado == DialogResult.OK)
                {
                    AgregarProfesor agregar = new AgregarProfesor();
                    Menu.MostrarMenu(agregar, this, 1);
                }
            }
            else
            {
                MessageBox.Show($"Todos los campos deben estar completos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool TodosLosTextBoxNoEstanVacios(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false; // Devuelve false si al menos un TextBox está vacío o contiene solo espacios en blanco
                    }
                }
                else if (c.HasChildren)
                {
                    // Llamada recursiva si el control actual tiene controles secundarios
                    if (!TodosLosTextBoxNoEstanVacios(c))
                    {
                        return false;
                    }
                }
            }

            return true; // Devuelve true si todos los TextBox no están vacíos
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            ListaProfesores listaProfesores = new ListaProfesores();
            Menu.MostrarMenu(listaProfesores, this, 1);
        }

        private void FechaDeNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = FechaDeNacimiento.Value.Date;
           
            string textoCampo = "Fecha de nacimiento";
            if (!ControlForm.EsMayorDeEdad( fechaNacimiento))
            {
                MessageBox.Show($"{textoCampo} invalida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return;
            }

            controlFocoFecha = true;
        }

        public void CargarPreCursos(List<Curso> lista)
        {


            // Convierte la lista de cursos a una lista de CursoViewModel
            List<CursoViewModel> listaCursosViewModel = lista
                .Select(curso => new CursoViewModel(curso.NombreConCodigo(), curso.Id)
                {


                })
                .ToList();

            // Configura el checkedListBoxPreCursos
            checkedListBoxCursosAsignados.DataSource = listaCursosViewModel;
            checkedListBoxCursosAsignados.DisplayMember = "NombreConCodigo";
            checkedListBoxCursosAsignados.ValueMember = "Id";
        }

        public void AsignarLista(List<Curso> lista)
        {
            CargarPreCursos(lista);
        }
        private List<string> obtenerCursosSeleccionados()
        {
            List<string> idsCursosSeleccionados = new List<string>();

            foreach (CursoViewModel cursoViewModel in checkedListBoxCursosAsignados.CheckedItems)
            {
                idsCursosSeleccionados.Add(cursoViewModel.Id.ToString());
            }
            return idsCursosSeleccionados;
        }
    }
}
