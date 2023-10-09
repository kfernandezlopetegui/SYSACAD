using Actualizar;
using Entidades;
using LecturaEscritura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using ToolTip = System.Windows.Forms.ToolTip;

namespace New_SYSACAD
{
    public partial class AgregarCurso : Form
    {
        private bool controlTocoFocoNombre = false;
        private bool controlTocoFocoCodigo = false;
        private bool controlTocoFocoDescripcion = false;
        private bool controlTocoFocoCupo = false;

        private string textoPorDefectoNombre = "Ingrese el nombre del Curso";
        private string textoPorDefectoCodigo = "Ingrese el codigo del curso";
        private string textoPorDefectoDescripcion = "Ingrese la descripcion del curso";
        private string textoPorDefectoCupo = "Ingrese cupo maximo";
        ToolTip toolTip = new ToolTip();


        public AgregarCurso()
        {
            InitializeComponent();
            buttonVolver.CausesValidation = false;

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

            textNombre.ForeColor = Color.Black;
        }

        private void textNombre_Enter(object sender, EventArgs e)
        {
            textNombre.Text = string.Empty;
            controlTocoFocoNombre = true;
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {
            textCodigo.ForeColor = Color.Black;

        }

        private void textCodigo_Enter(object sender, EventArgs e)
        {
            textCodigo.Text = string.Empty;
            controlTocoFocoCodigo = true;
        }

        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {
            toolTip.SetToolTip(textDescripcion, "Ingresar el dia de cursada, horario y aula en caso de que corresponda. DIA HH:mm-HH:mm");
            textDescripcion.ForeColor = Color.Black;
        }

        private void textDescripcion_Enter(object sender, EventArgs e)
        {
            textDescripcion.Text = string.Empty;
            controlTocoFocoDescripcion = true;
        }

        private void textCupo_TextChanged(object sender, EventArgs e)
        {
            textCupo.ForeColor = Color.Black;
        }

        private void textCupo_Enter(object sender, EventArgs e)
        {
            textCupo.Text = string.Empty;
            controlTocoFocoCupo = true;
        }

        private void textCodigo_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Codigo de curso";

            ControlForm.ValidarCampoNoVacio(textCodigo, textoCampo);
            ControlForm.ValidarCampoNoPorDefecto(textCodigo, textoCampo, textoPorDefectoCodigo);

            if (ValidarCurso.VerificarSiExisteCurso(textCodigo.Text) != null)
            {
                MessageBox.Show("El codigo  ya se encuentra ingresado en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textCodigo.Focus();
                return;
            }
        }

        private void textCupo_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Cantidad Cupo";

            ControlForm.ValidarCampoNoVacio(textCupo, textoCampo);
            ControlForm.ValidarCampoNoPorDefecto(textCupo, textoCampo, textoPorDefectoCupo);

            if (ValidarTipo.ValidarEsDigito(textCupo.Text))
            {
                MessageBox.Show("El cupo debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textCupo.Focus();
                return;
            }
        }

        private void textNombre_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Nombre Curso";

            ControlForm.ValidarCampoNoVacio(textNombre, textoCampo);
            ControlForm.ValidarCampoNoPorDefecto(textNombre, textoCampo, textoPorDefectoNombre);
        }

        private void textDescripcion_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Descripcion de curso";

            ControlForm.ValidarCampoNoVacio(textDescripcion, textoCampo);
            ControlForm.ValidarCampoNoPorDefecto(textDescripcion, textoCampo, textoPorDefectoDescripcion);
        }

        private void RestablecerColorTexto()
        {
            textCupo.ForeColor = SystemColors.GrayText;
            textNombre.ForeColor = SystemColors.GrayText;
            textDescripcion.ForeColor = SystemColors.GrayText;
            textCodigo.ForeColor = SystemColors.GrayText;
        }
        private void LimpiarCampos()
        {
            textNombre.Text = textoPorDefectoNombre;
            textCodigo.Text = textoPorDefectoCodigo;
            textDescripcion.Text = textoPorDefectoDescripcion;
            textCupo.Text = textoPorDefectoCupo;
        }
        private void RestablecerFormulario()
        {

            controlTocoFocoNombre = false;
            controlTocoFocoCodigo = false;
            controlTocoFocoDescripcion = false;
            controlTocoFocoCupo = false;
            LimpiarCampos();
            RestablecerColorTexto();

        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (controlTocoFocoCodigo && controlTocoFocoCupo && controlTocoFocoDescripcion && controlTocoFocoNombre)
            {
                string nombre = textNombre.Text;
                string codigo = textCodigo.Text;
                string descripcion = textDescripcion.Text;
                int cupo = int.Parse(textCupo.Text);

                Curso nuevoCurso = new Curso(nombre, codigo, descripcion, cupo);
                ActualizarCurso.AgregarCurso("cursosRegistrados.json", nuevoCurso);
                DialogResult resultado = MessageBox.Show("¡Registro exitoso! El curso se ha registrado correctamente.",
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

        private void buttonVolver_Click(object sender, EventArgs e)
        {

            ListaDeCursos listaCursos = new ListaDeCursos();
            Menu.MostrarMenu(listaCursos, this, 1);
        }
    }
}
