using Entidades;
using Interfaces;
using LogicaSysacad;
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

namespace New_SYSACAD
{
    public partial class AsignarCursoAProfesor : Form, ITraerListaCurso, IAsignarCursos
    {
        private ProfesorConCurso _profeSeleccionado;
        public AsignarCursoAProfesor(ProfesorConCurso profeSeleccionado)
        {
            InitializeComponent();

            var logica = new TraerListaCursoLogica(this);
            OnListaPedida?.Invoke();

            _profeSeleccionado = profeSeleccionado;
            label1.Text = $"Seleccione el/los curso/s que desea asignar a {_profeSeleccionado.Nombre} {_profeSeleccionado.Apellido}";
        }

        public event Action OnListaPedida;
        public event Action AsignarCursos;

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            ListaProfesores listaProfes = new ListaProfesores();
            Menu.MostrarMenu(listaProfes, this, 1);
        }

        private void buttonAsignar_Click(object sender, EventArgs e)
        {
            if (checkedListBoxCursosAsignados.CheckedItems.Count > 0)
            {
                List<string> listaCursosAsignados = obtenerCursosSeleccionados();

                var logicaAsignarCursos = new AgregarCursosAsignadosLogica(this, _profeSeleccionado.IdProfesor, listaCursosAsignados);

                AsignarCursos.Invoke();

                DialogResult resultado = MessageBox.Show($"¡Registro exitoso! Se ha asignado el curso a {_profeSeleccionado.Nombre} correctamente.",
                                             "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultado == DialogResult.OK)
                {
                    ListaProfesores listaProfes = new ListaProfesores();
                    Menu.MostrarMenu(listaProfes, this, 1);
                }
            }
            else
            {
                // Ningún elemento está seleccionado
                MessageBox.Show("Selecciona al menos un curso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AsignarLista(List<Curso> lista)
        {
            CargarPreCursos(lista);
        }

        public void CargarPreCursos(List<Curso> lista)
        {


            // Convierte la lista de cursos a una lista de CursoViewModel
            List<CursoViewModel> listaCursosViewModel = lista
                .Select(curso => new CursoViewModel(curso.NombreConCodigo(), curso.Id)
                {


                })
                .ToList();

            // Configura el checkedListBoxPreCursos
            checkedListBoxCursosAsignados.DataSource = listaCursosViewModel;
            checkedListBoxCursosAsignados.DisplayMember = "NombreConCodigo";
            checkedListBoxCursosAsignados.ValueMember = "Id";
        }

        private List<string> obtenerCursosSeleccionados()
        {
            List<string> idsCursosSeleccionados = new List<string>();

            foreach (CursoViewModel cursoViewModel in checkedListBoxCursosAsignados.CheckedItems)
            {
                idsCursosSeleccionados.Add(cursoViewModel.Id.ToString());
            }
            return idsCursosSeleccionados;
        }
    }
}

