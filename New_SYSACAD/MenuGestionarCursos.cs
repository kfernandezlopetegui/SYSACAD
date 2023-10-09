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
    public partial class MenuGestionarCursos : Form
    {
        public MenuGestionarCursos()
        {
            InitializeComponent();
        }

        private void buttonAgregarCurso_Click(object sender, EventArgs e)
        {
            AgregarCurso agregarCurso = new AgregarCurso();
            Menu.MostrarMenu(agregarCurso, this, 1);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            Menu.MostrarMenu(menuAdministrador, this, 1);
        }

        private void buttonEditarCurso_Click(object sender, EventArgs e)
        {
            EditarCurso editarCurso = new EditarCurso();
            Menu.MostrarMenu(editarCurso, this, 1);
        }

        private void buttonEliminarCurso_Click(object sender, EventArgs e)
        {
            EliminarCurso eliminarCurso = new EliminarCurso();
            Menu.MostrarMenu(eliminarCurso, this, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaDeCursos listaDeCursos = new ListaDeCursos();
            Menu.MostrarMenu(listaDeCursos, this, 1);
        }
    }
}
