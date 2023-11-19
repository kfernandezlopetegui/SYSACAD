using Actualizar;
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
using System.Threading.Tasks;
using System.Windows.Forms;


namespace New_SYSACAD
{
    public partial class EliminarCurso : Form, ITraerLista, IEliminarCurso
    {
       

        public event Action OnListaPedida;
        public event Action BorrarCurso;
        public Curso cursoSeleccionado;
        public EliminarCurso()
        {
            InitializeComponent();
            var logica = new TraerListaCursoLogica(this);
            
            OnListaPedida?.Invoke();
        }

        private void dataGridViewCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            cursoSeleccionado = (Curso)dataGridViewCursos.Rows[e.RowIndex].DataBoundItem;


            var logicaBorrar = new EliminarCursoLogica(this, cursoSeleccionado);

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar este curso?", "Confirmar eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                BorrarCurso.Invoke();

                DialogResult resultadoBorrado = MessageBox.Show("¡Eliminacion exitosa! El curso se ha borrado correctamente.",
                                           "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultadoBorrado == DialogResult.OK)
                {
                    ListaDeCursos listaCurso = new ListaDeCursos();
                    Menu.MostrarMenu(listaCurso, this, 1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaDeCursos listaCurso = new ListaDeCursos();
            Menu.MostrarMenu(listaCurso, this, 1);
        }

        public void AsignarLista<T>(List<T> lista)
        {
            dataGridViewCursos.DataSource = lista;
            dataGridViewCursos.Columns["CupoActual"].Visible = false;
            dataGridViewCursos.Columns["Id"].Visible = false;
            dataGridViewCursos.Columns["IdRequisitos"].Visible = false;
        }
    }
}
