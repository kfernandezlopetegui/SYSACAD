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

namespace New_SYSACAD
{
    public partial class EdicionDeCurso : Form
    {
        private Curso curso;
        private string codigoOriginal;
        public EdicionDeCurso(Curso curso)
        {
            InitializeComponent();
            this.curso = curso;

            codigoOriginal = curso.Codigo;
            textNombre.Text = curso.Nombre;
            textCodigo.Text = curso.Codigo;
            textDescripcion.Text = curso.Descripcion;
            textCupo.Text = curso.CupoMaximo.ToString();

        }




        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            curso.Nombre = textNombre.Text;
            curso.Descripcion = textDescripcion.Text;
            curso.CupoMaximo = int.Parse(textCupo.Text);
            curso.Codigo = textCodigo.Text;
            ActualizarCurso.EditarCurso(curso, "cursosRegistrados.json", codigoOriginal);

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
    }
}
