using Pagos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_SYSACAD
{
    public partial class FormComprobantePago : Form
    {
        public FormComprobantePago(ComprobantePago comprobantePago)
        {
            InitializeComponent();

            labelNumeroComprobante.Text = comprobantePago.NumeroComprobante;
            labelFecha.Text = comprobantePago.FechaPago.ToString();
            labelMonto.Text = comprobantePago.MontoPagado.ToString("C"); // Muestra el monto como una moneda
            labelMetodoPago.Text = comprobantePago.MetodoPago;
            labelDetalles.Text = comprobantePago.DetallesTransaccion;
            textConceptos.Text = string.Join("\r\n", comprobantePago.ConceptosPago);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            MenuEstudiante menuEstudiante = new MenuEstudiante();
            Menu.MostrarMenu(menuEstudiante, this, 1);
        }

        private void buttonDescargarPDF_Click(object sender, EventArgs e)
        {


        }
    }
}
