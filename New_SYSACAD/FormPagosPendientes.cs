using Actualizar;
using Login;
using Pagos;
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
    public partial class FormPagosPendientes : Form
    {
        private List<ConceptoPagos> listaConceptos;
        public FormPagosPendientes()
        {
            InitializeComponent();
            listaConceptos = ActualizarPagosPendientes.ListaPagosPendientes(SesionAlumno.AlumnoActual.Dni);
            dataGridView1.DataSource = listaConceptos;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            MenuEstudiante menuEstudiante = new MenuEstudiante();
            Menu.MostrarMenu(menuEstudiante, this, 1);
        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            MetodosDePago metodoPago = new MetodosDePago(10000, listaConceptos);
            Menu.MostrarMenu(metodoPago, this, 1);
            
        }
    }
}
