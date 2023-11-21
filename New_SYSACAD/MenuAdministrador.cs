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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            Menu.MostrarMenu(login, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroAlumno registro = new RegistroAlumno();

            Menu.MostrarMenu(registro, this);
        }

        private void MenuAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            ListaDeCursos listaCursos = new ListaDeCursos();
            Menu.MostrarMenu(listaCursos, this);

        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            InformesDisponibles informesDisponibles = new InformesDisponibles();
            Menu.MostrarMenu(informesDisponibles, this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GestionarRequisitosAcademicos gestionarRequisitos = new GestionarRequisitosAcademicos();
            Menu.MostrarMenu(gestionarRequisitos, this);
        }

        private void buttonManejarListaEspera_Click(object sender, EventArgs e)
        {
            CursosConListaEspera cursosConListaEspera = new CursosConListaEspera();
            Menu.MostrarMenu(cursosConListaEspera, this);
        }

        private void buttonGestionarProfesores_Click(object sender, EventArgs e)
        {
            ListaProfesores listaProfesores = new ListaProfesores();
            Menu.MostrarMenu(listaProfesores, this);
        }
    }
}
