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
    public partial class MostrarListaEsperaCurso : Form, ITraerLista
    {
        private Curso _cursoSeleccionado;
        public MostrarListaEsperaCurso(Curso cursoSeleccionado)
        {
            InitializeComponent();
            _cursoSeleccionado = cursoSeleccionado;
            var logica = new TraerListaDeEsperaCursoLogica(this, cursoSeleccionado.Codigo);
            OnListaPedida?.Invoke();
            labelTitulo.Text = $"Lista de espera de {cursoSeleccionado.Nombre}({cursoSeleccionado.Codigo})";
        }

        public event Action OnListaPedida;

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

        private void button1_Click(object sender, EventArgs e)
        {
            CursosConListaEspera cursosConLista = new CursosConListaEspera();
            Menu.MostrarMenu(cursosConLista, this, 1);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarDeListaEspera eliminarDeListaEspera = new EliminarDeListaEspera(_cursoSeleccionado);
            Menu.MostrarMenu(eliminarDeListaEspera, this, 1);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarAListaDeEspera agregarAListaDeEspera = new AgregarAListaDeEspera(_cursoSeleccionado);
            Menu.MostrarMenu(agregarAListaDeEspera, this, 1);
        }
    }
}
