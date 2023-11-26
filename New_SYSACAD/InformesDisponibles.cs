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
    public partial class InformesDisponibles : Form
    {
        public InformesDisponibles()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            Menu.MostrarMenu(menuAdministrador, this, 1);
        }

        private void buttonInscripciones_Click(object sender, EventArgs e)
        {
            PedirInformeInscripcionesPorPeriodo pedirInforme = new PedirInformeInscripcionesPorPeriodo();
            Menu.MostrarMenu(pedirInforme, this, 1);
        }

        private void buttonEstudiantesCurso_Click(object sender, EventArgs e)
        {
            PedirInformeEstudiantesPorCurso estudiantesPorCurso = new PedirInformeEstudiantesPorCurso();
            Menu.MostrarMenu(estudiantesPorCurso, this, 1);
        }

        private void buttonIngresosConceptos_Click(object sender, EventArgs e)
        {

        }

        private void buttonInscripcionPorCarrera_Click(object sender, EventArgs e)
        {

        }

        private void buttonListaEsperaCursos_Click(object sender, EventArgs e)
        {

        }
    }
}
