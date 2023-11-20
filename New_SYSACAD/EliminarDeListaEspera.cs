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
    public partial class EliminarDeListaEspera : Form, ITraerLista, IEliminarEleccionLE
    {
        private Curso _cursoDeListaEspera;
        private SolicitudListaEsperaDetallada seleccion;
        public EliminarDeListaEspera(Curso cursoDeListaEspera)
        {
            InitializeComponent();
            _cursoDeListaEspera= cursoDeListaEspera;
            var logica = new TraerListaDeEsperaCursoLogica(this, _cursoDeListaEspera.Codigo);
            OnListaPedida?.Invoke();
            labelTitulo.Text = $"Lista de espera de {_cursoDeListaEspera.Nombre}({_cursoDeListaEspera.Codigo})";
        }

        public event Action OnListaPedida;
        public event Action EliminarEleccion;

        private void dataGridViewCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           seleccion = (SolicitudListaEsperaDetallada)dataGridViewCursos.Rows[e.RowIndex].DataBoundItem;


            var logicaBorrar = new EliminarSeleccionListaEsperaLogica(this, seleccion);

            DialogResult resultado = MessageBox.Show($"¿Estás seguro de proceder con la eliminacion de {seleccion.NombreAlumno} de la lista de espera?", "Confirmar eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                EliminarEleccion.Invoke();

                DialogResult resultadoBorrado = MessageBox.Show("¡Eliminacion exitosa!",
                                           "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultadoBorrado == DialogResult.OK)
                {
                    MostrarListaEsperaCurso cursosConLista = new MostrarListaEsperaCurso(_cursoDeListaEspera);
                    Menu.MostrarMenu(cursosConLista, this, 1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarListaEsperaCurso cursosConLista = new MostrarListaEsperaCurso(_cursoDeListaEspera);
            Menu.MostrarMenu(cursosConLista, this, 1);
        }

        public void AsignarLista<T>(List<T> lista)
        {
            dataGridViewCursos.DataSource = lista;
            dataGridViewCursos.Columns["IdSolicitud"].Visible = false;
            dataGridViewCursos.Columns["FechaSolicitud"].HeaderText = "Fecha de solicitud";
            dataGridViewCursos.Columns["IdCurso"].Visible = false;
            dataGridViewCursos.Columns["NombreCurso"].Visible = false;
            dataGridViewCursos.Columns["IdAlumno"].HeaderText = "DNI alumno";
            dataGridViewCursos.Columns["NombreAlumno"].HeaderText = "Nombre del alumno";
            dataGridViewCursos.Columns["ApellidoAlumno"].HeaderText = "Apellido del alumno";
            dataGridViewCursos.Columns["LegajoAlumno"].HeaderText = "Legajo del alumno";
            foreach (DataGridViewColumn column in dataGridViewCursos.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
