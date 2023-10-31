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
        private bool controlTocoFocoCarrera = false;
        private bool controlTocoFocoHorario = false;
        private bool controlTocoFocoCursada = false;
        private List<Curso> listaCursos = ActualizarCurso.ListaCursosActuales("cursosRegistrados.json");
        ToolTip toolTip = new ToolTip();
        List<string> opcionesDias = new List<string> { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };
        List<string> opcionesTurno = new List<string> { "08:30-12:30", "08:30-10:30", "10:30-12:30", "14:00-18:00",
            "14:00-16:00", "16:00-18:00", "18:30-22:30", "18:30-20:30", "20:30-22:30" };
        List<string> opcionesCarrera = new List<string> { "Sin seleccionar", "TUP", "TUSI" };



        public AgregarCurso()
        {
            InitializeComponent();
            buttonVolver.CausesValidation = false;
            checkedListBoxDiasCursada.DataSource = opcionesDias;
            checkedListBoxHorario.DataSource = opcionesTurno;
            checkedListBoxPreCursos.DataSource = listaCursos;
            checkedListBoxPreCursos.DisplayMember = "NombreConCodigo";
            comboBoxCarrera.DataSource = opcionesCarrera;
        }

        private void textNombre_Enter(object sender, EventArgs e)
        {

            controlTocoFocoNombre = true;
        }



        private void textCodigo_Enter(object sender, EventArgs e)
        {

            controlTocoFocoCodigo = true;
        }

        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {
            toolTip.SetToolTip(textDescripcion, "Ingresar el numero del aula");

        }

        private void textDescripcion_Enter(object sender, EventArgs e)
        {

            controlTocoFocoDescripcion = true;
        }

        private void textCupo_Enter(object sender, EventArgs e)
        {

            controlTocoFocoCupo = true;
        }

        private void textCodigo_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Codigo de curso";

            ControlForm.ValidarCampoNoVacio(textCodigo, textoCampo);


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

        }

        private void textDescripcion_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Descripcion de curso";

            ControlForm.ValidarCampoNoVacio(textDescripcion, textoCampo);

        }


        private void RestablecerFormulario()
        {

            AgregarCurso nuevoAgregarCurso = new AgregarCurso();
            Menu.MostrarMenu(nuevoAgregarCurso, this, 1);

        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (controlTocoFocoCodigo && controlTocoFocoCupo && controlTocoFocoDescripcion && controlTocoFocoNombre && controlTocoFocoCarrera && controlTocoFocoCursada && controlTocoFocoHorario)
            {
                string nombre = textNombre.Text;
                string codigo = textCodigo.Text;
                string descripcion = ObtenerDescripcion();
                int cupo = int.Parse(textCupo.Text);
                string carrera = comboBoxCarrera.SelectedItem.ToString();

                List<string> listaIdCursos = obtenerCursosSeleccionados();
                int creditos = int.Parse(textBoxCreditosObtenidos.Text);
                double promedio = double.Parse(textBoxPromedio.Text);

                RequisitosAcademicos requisitosAcademicos = new RequisitosAcademicos(listaIdCursos,creditos,promedio);

                Curso nuevoCurso = new Curso(nombre, codigo, descripcion, cupo, carrera, requisitosAcademicos.Id);

                ActualizarCurso.AgregarCurso("cursosRegistrados.json", nuevoCurso);
                ActualizarRequisitos.AgregarRequisitos("requisitosRegistrados.json", requisitosAcademicos);

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

        private string ObtenerDescripcion()
        {

            string diasSeleccionados = "";
            string horariosSeleccionados = "";
            string aulaSeleccionada = "Aula: " + textDescripcion.Text;

            for (int i = 0; i < checkedListBoxDiasCursada.CheckedItems.Count; i++)
            {
                diasSeleccionados += checkedListBoxDiasCursada.CheckedItems[i].ToString();
                if (i < checkedListBoxDiasCursada.CheckedItems.Count - 1)
                {
                    diasSeleccionados += " y ";
                }
            }


            for (int i = 0; i < checkedListBoxHorario.CheckedItems.Count; i++)
            {
                horariosSeleccionados += checkedListBoxHorario.CheckedItems[i].ToString();
                if (i < checkedListBoxHorario.CheckedItems.Count - 1)
                {
                    horariosSeleccionados += ",";
                }
            }


            string descripcionObtenida = diasSeleccionados + " " + horariosSeleccionados + " " + aulaSeleccionada;


            return descripcionObtenida;
        }



        private void comboBoxCarrera_Enter(object sender, EventArgs e)
        {
            controlTocoFocoCarrera = true;


        }

        private void checkedListBoxHorario_Enter(object sender, EventArgs e)
        {
            controlTocoFocoHorario = true;
        }

        private void checkedListBoxDiasCursada_Enter(object sender, EventArgs e)
        {
            controlTocoFocoCursada = true;

        }

        private void comboBoxCarrera_Validated(object sender, EventArgs e)
        {
            if (comboBoxCarrera.SelectedItem.ToString() == "Sin seleccionar")
            {
                MessageBox.Show("El campo carrera no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> obtenerCursosSeleccionados()
        {
            List<string> idsCursosSeleccionados = new List<string>();

            foreach (Curso curso in checkedListBoxPreCursos.CheckedItems)
            {
                idsCursosSeleccionados.Add(curso.Codigo);
            }
            return idsCursosSeleccionados;
        }
    }
}
