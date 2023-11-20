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
    public partial class AgregarAListaDeEspera : Form, ITraerLista, IAgregarAListaEspera
    {
        private Curso _cursoDeListaEspera;
        public AgregarAListaDeEspera(Curso cursoSeleccionado)
        {
            InitializeComponent();
            _cursoDeListaEspera = cursoSeleccionado;
            label1.Text = $"Seleccione el alumno que desea agregar a la lista de espera del curso {_cursoDeListaEspera.Nombre}({_cursoDeListaEspera.Codigo}) ";
            var logica = new TraerListaAlumnosLogica(this);
            OnListaPedida?.Invoke();
        }

        public event Action OnListaPedida;
        public event Action AgregarAListaEspera;

        public void AsignarLista<T>(List<T> lista)
        {
            dataGridViewCursos.AutoGenerateColumns = true;
            dataGridViewCursos.DataSource = lista;

            dataGridViewCursos.Columns["Nombre"].HeaderText = "Nombre del Alumno";
            dataGridViewCursos.Columns["Apellido"].HeaderText = "Apellido del Alumno";
            dataGridViewCursos.Columns["Legajo"].HeaderText = "Legajo del Alumno";
            dataGridViewCursos.Columns["Dni"].HeaderText = "Dni del Alumno";
            dataGridViewCursos.Columns["Direccion"].Visible = false;
            dataGridViewCursos.Columns["Telefono"].Visible = false;
            dataGridViewCursos.Columns["ConceptoPagos"].Visible = false;
            dataGridViewCursos.Columns["CursosAprobados"].Visible = false;
            dataGridViewCursos.Columns["Creditos"].Visible = false;
            dataGridViewCursos.Columns["Promedio"].Visible = false;
            dataGridViewCursos.Columns["Sexo"].Visible = false;
            dataGridViewCursos.Columns["Email"].Visible = false;
            dataGridViewCursos.Columns["Clave"].Visible = false;
            dataGridViewCursos.Columns["ClaveTemporal"].Visible = false;
            dataGridViewCursos.Columns["LoginStatus"].Visible = false;
            dataGridViewCursos.Columns["Rol"].Visible = false;
            dataGridViewCursos.Columns["FechaDeNacimiento"].Visible = false;
            dataGridViewCursos.Columns["PalabraClave"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCursos.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dataGridViewCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Alumno alumnoSeleccionado = (Alumno)dataGridViewCursos.Rows[e.RowIndex].DataBoundItem;

            var logicaBorrar = new AgregarAlistaEsperaLogica(this, _cursoDeListaEspera, alumnoSeleccionado);

            DialogResult resultado = MessageBox.Show($"¿Estás seguro de agregar a  {alumnoSeleccionado.Nombre} a la lista de espera de {_cursoDeListaEspera.Nombre}?", "Confirmar eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                AgregarAListaEspera.Invoke();

                DialogResult resultadoBorrado = MessageBox.Show("¡Operacion exitosa!",
                                           "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultadoBorrado == DialogResult.OK)
                {
                    MostrarListaEsperaCurso cursosConLista = new MostrarListaEsperaCurso(_cursoDeListaEspera);
                    Menu.MostrarMenu(cursosConLista, this, 1);
                }
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MostrarListaEsperaCurso cursosConLista = new MostrarListaEsperaCurso(_cursoDeListaEspera);
            Menu.MostrarMenu(cursosConLista, this, 1);
        }
    }
}
