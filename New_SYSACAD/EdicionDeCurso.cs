using Actualizar;
using Entidades;
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
using static Entidades.Enumerados;
namespace New_SYSACAD
{
    public partial class EdicionDeCurso : Form
    {
        private Curso curso;
        private string codigoOriginal;
        List<DiaSemana> opcionesDias = new List<DiaSemana> { DiaSemana.Lunes, DiaSemana.Martes, DiaSemana.Miércoles, DiaSemana.Jueves, DiaSemana.Viernes, DiaSemana.Sábado };
        List<string> opcionesTurno = new List<string> { "08:30-12:30", "08:30-10:30", "10:30-12:30", "14:00-18:00",
            "14:00-16:00", "16:00-18:00", "18:30-22:30", "18:30-20:30", "20:30-22:30" };
        public EdicionDeCurso(Curso curso)
        {
            InitializeComponent();
            this.curso = curso;

            codigoOriginal = curso.Codigo;
            textNombre.Text = curso.Nombre;
            textCodigo.Text = curso.Codigo;
            textCupo.Text = curso.CupoMaximo.ToString();
            CargarDatos();

        }




        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            curso.Nombre = textNombre.Text;
            curso.Descripcion = ObtenerDescripcion();
            curso.CupoMaximo = int.Parse(textCupo.Text);
            curso.Codigo = textCodigo.Text;
            ActualizarCurso.EditarCursoBD(curso, codigoOriginal);

            DialogResult resultado = MessageBox.Show("¡Actualizacion exitosa! El curso se ha actualizado correctamente.",
                                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                EditarCurso menuEditarCursos = new EditarCurso();
                Menu.MostrarMenu(menuEditarCursos, this, 1);
            }
        }

        private void textNombre_Validated_1(object sender, EventArgs e)
        {
            string textoCampo = "Descripcion de curso";

            ControlForm.ValidarCampoNoVacio(textDescripcion, textoCampo);
        }

        private void textCodigo_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Codigo de curso";

            ControlForm.ValidarCampoNoVacio(textCodigo, textoCampo);

            if (codigoOriginal != textCodigo.Text)
            {
                if (ValidarCurso.VerificarSiExisteCurso(textCodigo.Text) != null)
                {
                    MessageBox.Show("El codigo  ya se encuentra ingresado en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textCodigo.Focus();
                    return;
                }
            }
        }

        private void textDescripcion_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Descripcion de curso";

            ControlForm.ValidarCampoNoVacio(textDescripcion, textoCampo);
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

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            EditarCurso menuEditarCursos = new EditarCurso();
            Menu.MostrarMenu(menuEditarCursos, this, 1);
        }

        private DescripcionSeleccionada ObtenerDescripcionDesdeString(string descripcion)
        {
            DescripcionSeleccionada descripcionCurso = new DescripcionSeleccionada();

            // Aquí asumimos que la descripción sigue el formato generado en ObtenerDescripcion
            string[] partesDescripcion = descripcion.Split(' ');

            // Configurar días
            descripcionCurso.DiasSeleccionados = partesDescripcion
                .Where(part => Enum.TryParse(part, out DiaSemana dia))
                .Select(dia => (DiaSemana)Enum.Parse(typeof(DiaSemana), dia))
                .ToList();

            // Configurar horarios
            descripcionCurso.HorariosSeleccionados = partesDescripcion
                .Where(part => opcionesTurno.Contains(part))
                .ToList();

            // Configurar aula
            descripcionCurso.AulaSeleccionada = DescripcionCurso.ObtenerAula(descripcion);

            return descripcionCurso;
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


            for (int i = 0; i < checkedListBoxHorarios.CheckedItems.Count; i++)
            {
                horariosSeleccionados += checkedListBoxHorarios.CheckedItems[i].ToString();
                if (i < checkedListBoxHorarios.CheckedItems.Count - 1)
                {
                    horariosSeleccionados += ",";
                }
            }


            string descripcionObtenida = diasSeleccionados + " " + horariosSeleccionados + " " + aulaSeleccionada;


            return descripcionObtenida;
        }

        private void CargarDatos()
        {
           
            var descripcionCurso = ObtenerDescripcionDesdeString(curso.Descripcion);

            // Configurar elementos del formulario con la información de la descripción
            checkedListBoxDiasCursada.DataSource = opcionesDias;
            SeleccionarDiasCursada(descripcionCurso);

            checkedListBoxHorarios.DataSource = opcionesTurno;
            foreach (var horario in descripcionCurso.HorariosSeleccionados)
            {
                checkedListBoxHorarios.SetItemChecked(opcionesTurno.IndexOf(horario), true);
            }

            textDescripcion.Text = descripcionCurso.AulaSeleccionada;
        }

        private void SeleccionarDiasCursada(DescripcionSeleccionada descripcionCurso)
        {
            // Iterar sobre los elementos en la lista de días de la descripción del curso
            foreach (var diaEnDescripcion in descripcionCurso.DiasSeleccionados)
            {
                // Intentar encontrar el índice del día en la lista de opcionesDias
                int index = opcionesDias.IndexOf(diaEnDescripcion);

                // Verificar si el índice es válido antes de marcar el elemento
                if (index != -1 && index < checkedListBoxDiasCursada.Items.Count)
                {
                    checkedListBoxDiasCursada.SetItemChecked(index, true);
                }
            }
        }
    }
}
