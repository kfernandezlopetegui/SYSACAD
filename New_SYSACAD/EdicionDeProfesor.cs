using DB;
using Entidades;
using Interfaces;
using LecturaEscritura;
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

namespace New_SYSACAD
{
    public partial class EdicionDeProfesor : Form, ITraerListaCurso, ITraerProfesor, IActualizarProfesor, IActualizarCursosAsignados
    {
        private ProfesorConCurso _profeSeleccionado;
        private Profesor profe;
        public EdicionDeProfesor(ProfesorConCurso profeSeleccionado)
        {
            InitializeComponent();
            _profeSeleccionado = profeSeleccionado;
            var logica = new TraerListaCursoLogica(this);
            OnListaPedida?.Invoke();

            var logicaProfesor = new TraerProfesorLogica(this, profeSeleccionado.IdProfesor);
            OnProfesorPedido?.Invoke();


        }

        public event Action OnListaPedida;
        public event Action OnProfesorPedido;
        public event Action ActualizarProfesor;
        public event Action ActualizarCursosAsignados;

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (TodosLosTextBoxNoEstanVacios(this))
            {
                int dni = int.Parse(textDni.Text);
                string nombre = textNombre.Text;
                string apellido = textApellido.Text;
                string telefono = textBoxNumeroTel.Text;
                string mail = textEmail.Text;
                string direccion = textBoxDireccion.Text;
                string palabraClave = textBoxPalabraClave.Text;
                string areasEspecializacion = textBoxAreasEspecializacion.Text;

                var actualizarProfe = new EditarProfesorLogica(this, profe, dni, nombre, apellido, telefono, mail, direccion, palabraClave, areasEspecializacion);
                ActualizarProfesor.Invoke();

                List<string> listaCursosAsignados = obtenerCursosSeleccionados();

                var actualizarCursosAsignados = new ActualizarCursosAsignadosLogica(this, profe.Dni, listaCursosAsignados);
                ActualizarCursosAsignados.Invoke();

                DialogResult resultado = MessageBox.Show("¡Actualizacion Exitosa! El Profesor se ha actualizado correctamente.",
                                             "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultado == DialogResult.OK)
                {
                    ListaProfesores listaProfesores = new ListaProfesores();
                    Menu.MostrarMenu(listaProfesores, this, 1);
                }

            }
            else
            {
                MessageBox.Show($"Todos los campos deben estar completos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            ListaProfesores listaProfesores = new ListaProfesores();
            Menu.MostrarMenu(listaProfesores, this, 1);
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

        
        public void AsignarLista(List<Curso> lista)
        {
            CargarPreCursos(lista);
        }

        public void CargarPreCursos(List<Curso> listaCursos)
        {
            List<string> listaIdsCoincidentes = CRUDB.ObtenerIdCursosPorIdProfesor(_profeSeleccionado.IdProfesor);
            var cursosConSeleccion = listaCursos.Select(curso => new CursoConSeleccion
            {
                Curso = curso,
                Seleccionado = listaIdsCoincidentes.Contains(curso.Codigo)
            }).ToList();

            checkedListBoxCursosAsignados.DataSource = cursosConSeleccion;
            checkedListBoxCursosAsignados.DisplayMember = "Curso";
            checkedListBoxCursosAsignados.ValueMember = "Seleccionado";

            checkedListBoxCursosAsignados.Format += (sender, e) =>
            {
                if (e.ListItem is CursoConSeleccion cursoConSeleccion)
                {
                    e.Value = $"{cursoConSeleccion.Curso.Nombre} ({cursoConSeleccion.Curso.Codigo})";
                }
            };

            for (int i = 0; i < checkedListBoxCursosAsignados.Items.Count; i++)
            {
                checkedListBoxCursosAsignados.SetItemChecked(i, cursosConSeleccion[i].Seleccionado);
            }
        }

        public void CargarDatos(Profesor profe)
        {
            this.profe = profe;

            textDni.Text = profe.Dni.ToString();
            textNombre.Text = profe.Nombre;
            textApellido.Text = profe.Apellido;
            textBoxNumeroTel.Text = profe.NumeroTelefono;
            textEmail.Text = profe.Email;
            textBoxDireccion.Text = profe.Direccion;
            textBoxPalabraClave.Text = profe.PalabraClave;
            textBoxAreasEspecializacion.Text = profe.AreasEspecializacion;

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
    }
}
