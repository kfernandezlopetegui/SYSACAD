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
    }
}
