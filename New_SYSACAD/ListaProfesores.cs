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
    public partial class ListaProfesores : Form, ITraerLista, IEliminarEleccionLE
    {
        private ProfesorConCurso seleccion;
        private bool seleccionHecha = false;
        public ListaProfesores()
        {
            InitializeComponent();
            var logica = new TraerListaProfesoresLogica(this);
            OnListaPedida?.Invoke();
        }

        public event Action OnListaPedida;
        public event Action EliminarEleccion;

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            Menu.MostrarMenu(menuAdministrador, this, 1);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(seleccionHecha)
            {
                var logicaBorrar = new EliminarProfesorLogica(this, seleccion);

                DialogResult resultado = MessageBox.Show($"¿Estás seguro de proceder con la eliminacion de {seleccion.Nombre} {seleccion.Apellido} de la lista?", "Confirmar eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    EliminarEleccion.Invoke();

                    DialogResult resultadoBorrado = MessageBox.Show("¡Eliminacion exitosa!",
                                               "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (resultadoBorrado == DialogResult.OK)
                    {
                        ListaProfesores listaProfesores = new ListaProfesores();
                        Menu.MostrarMenu(listaProfesores, this, 1);
                    }
                }

            }
            else
            {
                // Ningún elemento está seleccionado
                MessageBox.Show("Debes seleccionar a un profesor para poder continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (seleccionHecha)
            {
                EdicionDeProfesor edicionProfe = new EdicionDeProfesor(seleccion);
                Menu.MostrarMenu(edicionProfe, this, 1);
            }
            else
            {
                // Ningún elemento está seleccionado
                MessageBox.Show("Debes seleccionar a un profesor para poder continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarProfesor agregarProfesor = new AgregarProfesor();
            Menu.MostrarMenu(agregarProfesor, this, 1);
        }

        private void dataGridViewCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccion = (ProfesorConCurso)dataGridViewCursos.Rows[e.RowIndex].DataBoundItem;
            seleccionHecha = true;
        }

        private void buttonAsignarCursos_Click(object sender, EventArgs e)
        {
            if (seleccionHecha)
            {
                AsignarCursoAProfesor asignarCurso = new AsignarCursoAProfesor(seleccion);
                Menu.MostrarMenu(asignarCurso, this, 1);
            }
            else
            {
                // Ningún elemento está seleccionado
                MessageBox.Show("Debes seleccionar a un profesor para poder continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void AsignarLista<T>(List<T> lista)
        {
            dataGridViewCursos.AutoGenerateColumns = true;
            dataGridViewCursos.DataSource = lista;


            dataGridViewCursos.Columns["IdProfesor"].HeaderText = "Dni";
            dataGridViewCursos.Columns["AreasEspecializacion"].HeaderText = "Areas de especializacion";
            dataGridViewCursos.Columns["Email"].HeaderText = "Correo electronico";
            dataGridViewCursos.Columns["CursosAsignados"].HeaderText = "Cursos asignados";
            dataGridViewCursos.Columns["NumeroTelefono"].HeaderText = "Numero de telefono";



            foreach (DataGridViewColumn column in dataGridViewCursos.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
