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
    /// <summary>
    /// Formulario para gestionar los pagos pendientes de un estudiante.
    /// </summary>
    public partial class FormPagosPendientes : Form
    {
        private List<ConceptoPagos> listaConceptos;
        private List<ConceptoPagos> listaAPagar = new List<ConceptoPagos>();
        private decimal importeFinal;
        public FormPagosPendientes()
        {
            InitializeComponent();

            CargarConceptos();
            DataGridViewTextBoxColumn columnaImporteAPagar = new DataGridViewTextBoxColumn();
            columnaImporteAPagar.HeaderText = "Importe a Pagar";
            columnaImporteAPagar.Name = "ImporteAPagar";
            columnaImporteAPagar.DataPropertyName = "ImporteAPagar"; // Asocia esta columna con la propiedad en tu objeto de datos
            columnaImporteAPagar.ReadOnly = false; // Permite la edición
            dataGridView1.Columns.Add(columnaImporteAPagar);
        }
        /// <summary>
        /// Maneja el evento Click del botón "Volver". Regresa al menú principal del estudiante.
        /// </summary>
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            MenuEstudiante menuEstudiante = new MenuEstudiante();
            Menu.MostrarMenu(menuEstudiante, this, 1);
        }
        /// <summary>
        /// Maneja el evento Click del botón "Inscripción". Abre el formulario de métodos de pago si hay un importe a pagar y conceptos seleccionados.
        /// </summary>
        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            if (importeFinal != 0 && listaAPagar.Count() > 0)
            {
                MetodosDePago metodoPago = new MetodosDePago(importeFinal, listaAPagar);
                Menu.MostrarMenu(metodoPago, this, 1);
            }
            else
            {
                MessageBox.Show($"No has ingresado ningun importe a pagar.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// <summary>
        /// Maneja el evento CellEndEdit del DataGridView. Captura el importe ingresado por el usuario y lo agrega a la lista de pagos a realizar.
        /// </summary>
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ImporteAPagar"].Index && e.RowIndex >= 0)
            {

                string conceptoPago = dataGridView1.Rows[e.RowIndex].Cells["Concepto"].Value.ToString();


                object valor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;


                if (valor != null && conceptoPago != null && decimal.TryParse(valor.ToString(), out decimal importe))
                {


                    importeFinal = importeFinal + importe;
                    listaAPagar.Add(new ConceptoPagos(importe, conceptoPago));
                }
                else
                {
                    MessageBox.Show($"Valor ingreado no valido.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    
        public async void CargarConceptos()
        {
            listaConceptos = await ActualizarPagosPendientes.ListaPagosPendientes(SesionAlumno.AlumnoActual.Dni);
            dataGridView1.DataSource = listaConceptos;
        }
    
    }
}
