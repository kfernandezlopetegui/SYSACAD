using Actualizar;
using DB;
using Entidades;
using Interfaces;
using LecturaEscritura;
using LogicaSysacad;
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
    public partial class EdicionRequisito : Form, IActualizarRequisito
    {
        private List<Curso> listaCursos = ActualizarCurso.ListaCursosActualesBD();
        CursoConRequisitos cursoConRequisitos;

        public event Action ActualizarRequisito;

        public EdicionRequisito(CursoConRequisitos cursoConRequisitos)
        {
            InitializeComponent();
            this.cursoConRequisitos = cursoConRequisitos;
            textBoxCreditosObtenidos.Text = this.cursoConRequisitos.CantidadMinimaCreditos.ToString();
            textBoxPromedio.Text = this.cursoConRequisitos.PromedioMinimo.ToString();
            labelTituloNombre.Text = $"Requisitos Academicos de {cursoConRequisitos.NombreCurso} ({cursoConRequisitos.CodigoCurso})";
            CargarPreCursos();
        }

        public void CargarPreCursos()
        {
            List<string> listaIdsCoincidentes = CRUD.ConvertirJsonALista<string>(cursoConRequisitos.IdCursosCorrelativos);
            var cursosConSeleccion = listaCursos.Select(curso => new CursoConSeleccion
            {
                Curso = curso,
                Seleccionado = listaIdsCoincidentes.Contains(curso.Codigo)
            }).ToList();

            checkedListBoxPreCursos.DataSource = cursosConSeleccion;
            checkedListBoxPreCursos.DisplayMember = "Curso";
            checkedListBoxPreCursos.ValueMember = "Seleccionado";

            checkedListBoxPreCursos.Format += (sender, e) =>
            {
                if (e.ListItem is CursoConSeleccion cursoConSeleccion)
                {
                    e.Value = $"{cursoConSeleccion.Curso.Nombre} ({cursoConSeleccion.Curso.Codigo})";
                }
            };

            for (int i = 0; i < checkedListBoxPreCursos.Items.Count; i++)
            {
                checkedListBoxPreCursos.SetItemChecked(i, cursosConSeleccion[i].Seleccionado);
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            GestionarRequisitosAcademicos gestionarRequisitos = new GestionarRequisitosAcademicos();
            Menu.MostrarMenu(gestionarRequisitos, this, 1);
        }

        private List<string> obtenerCursosSeleccionados()
        {
            List<string> codigosCursosSeleccionados = new List<string>();

            foreach (CursoConSeleccion cursoConSeleccion in checkedListBoxPreCursos.CheckedItems)
            {
                codigosCursosSeleccionados.Add(cursoConSeleccion.Curso.Codigo);
            }
            return codigosCursosSeleccionados;
        }

        private void textBoxCreditosObtenidos_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Creditos minimos";

            ControlForm.ValidarCampoNoVacio(textBoxCreditosObtenidos, textoCampo);


            if (ValidarTipo.ValidarEsDigito(textBoxCreditosObtenidos.Text))
            {
                MessageBox.Show("Creditos minimos debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCreditosObtenidos.Focus();
                return;
            }
        }

        private void textBoxPromedio_Validated(object sender, EventArgs e)
        {
            string textoCampo = "Promedio minimo";

            ControlForm.ValidarCampoNoVacio(textBoxPromedio, textoCampo);


            if (ValidarTipo.ValidarEsDigito(textBoxPromedio.Text))
            {
                MessageBox.Show("Promedio minimo debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPromedio.Focus();
                return;
            }
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            List<string> listaIdCursos = obtenerCursosSeleccionados();

            Curso cursoDelRequisito = await CRUDB.ObtenerPorIdentificadorAsync<Curso>("Curso", "Codigo = @Codigo", new { Codigo = cursoConRequisitos.CodigoCurso });

            int creditos = int.Parse(textBoxCreditosObtenidos.Text);
            double promedio = double.Parse(textBoxPromedio.Text);

            var actualizar = new ActualizarRequisitoLogica(this, listaIdCursos,
            cursoDelRequisito, creditos,  promedio, cursoConRequisitos);

            ActualizarRequisito.Invoke();


            DialogResult resultado = MessageBox.Show($"¡Actualizacion exitosa! El requisito academico de {cursoConRequisitos.NombreCurso} se ha actualizado correctamente.",
                                             "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                GestionarRequisitosAcademicos gestionarRequisitos = new GestionarRequisitosAcademicos();
                Menu.MostrarMenu(gestionarRequisitos, this, 1);
            }

        }
    }
}
