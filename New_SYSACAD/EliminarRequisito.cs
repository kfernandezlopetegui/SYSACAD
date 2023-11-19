using Actualizar;
using DB;
using Entidades;
using LecturaEscritura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_SYSACAD
{
    public partial class EliminarRequisito : Form
    {
        List<Curso> listaCursos = ActualizarCurso.ListaCursosActualesBD();
        List<RequisitosAcademicos> listaRequisitos = ActualizarRequisitos.ListaRequisitosActuales();
        List<CursoConRequisitos> cursosConRequisitos;
        public EliminarRequisito()
        {
            InitializeComponent();
            dataGridViewCursos.DataSource = listaCursos;
            cursosConRequisitos = GestionarRequisitosAcademicos.ObtenerCursosConRequisitos(listaCursos, listaRequisitos);
            dataGridViewCursos.DataSource = cursosConRequisitos;
            dataGridViewCursos.Columns["IdCursosCorrelativos"].Visible = false;
        }

        private async void dataGridViewCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CursoConRequisitos cursoSeleccionado = (CursoConRequisitos)dataGridViewCursos.Rows[e.RowIndex].DataBoundItem;

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar este requisito?", "Confirmar eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                List<string> listaVacia = new List<string>();
                string stringJson = CRUD.ConvertirListaAJson(listaVacia);
                RequisitosAcademicos requisitosAcademicos = new RequisitosAcademicos(stringJson, 0, 0);
                ActualizarRequisitos.AgregarRequisitos(requisitosAcademicos);

                Curso cursoDelRequisito = await CRUDB.ObtenerPorIdentificadorAsync<Curso>("Curso", "Codigo = @Codigo", new { Codigo = cursoSeleccionado.CodigoCurso });
                int idEliminar = cursoDelRequisito.IdRequisitos;
                cursoDelRequisito.IdRequisitos = requisitosAcademicos.Id;
                await CRUDB.ActualizarPorIdentificadorAsync("Curso", "Codigo", cursoSeleccionado.CodigoCurso, cursoDelRequisito);

                ActualizarRequisitos.BorrarRequisitoPorId(idEliminar);

                DialogResult resultadoBorrado = MessageBox.Show("¡Eliminacion exitosa! El curso se ha borrado correctamente.",
                                           "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultadoBorrado == DialogResult.OK)
                {
                    GestionarRequisitosAcademicos gestionarRequisitos = new GestionarRequisitosAcademicos();
                    Menu.MostrarMenu(gestionarRequisitos, this, 1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionarRequisitosAcademicos gestionarRequisitos = new GestionarRequisitosAcademicos();
            Menu.MostrarMenu(gestionarRequisitos, this, 1);
        }
    }
}
