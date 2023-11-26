using Entidades;
using Interfaces;
using LogicaSysacad;
using PDF;
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
    public partial class PedirInformeInscripcionesPorPeriodo : Form, IPedirInforme
    {
        public PedirInformeInscripcionesPorPeriodo()
        {
            InitializeComponent();
        }

        public event Action OnPedirInforme;

        private void buttonInscripciones_Click(object sender, EventArgs e)
        {
            Periodo periodo = new Periodo("Periodo",dateTimePickerInicio.Value, dateTimePickerFin.Value);
            PedirInformePeriodoInscripcionesLogica pedirInforme = new PedirInformePeriodoInscripcionesLogica(this, periodo);
            OnPedirInforme.Invoke();
            PedirInformeInscripcionesPorPeriodo pedirInformeForm = new PedirInformeInscripcionesPorPeriodo();
            Menu.MostrarMenu(pedirInformeForm, this, 1);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            InformesDisponibles informes = new InformesDisponibles();
            Menu.MostrarMenu(informes, this, 1);

        }

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            ValidarFechaInicio();
        }

        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            ValidarFechaFin();
        }

        private void ValidarFechaInicio()
        {
            if (dateTimePickerInicio.Value > dateTimePickerFin.Value)
            {
                // La fecha de inicio es posterior a la fecha de fin
                // Mostrar mensaje de error
                MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Establecer la fecha de inicio en el día de hoy
                dateTimePickerInicio.Value = DateTime.Today;
            }
        }

        private void ValidarFechaFin()
        {
            if (dateTimePickerFin.Value < dateTimePickerInicio.Value)
            {
                // La fecha de fin es anterior a la fecha de inicio
                // Mostrar mensaje de error
                MessageBox.Show("La fecha de fin debe ser posterior a la fecha de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Establecer la fecha de fin en el día de hoy
                dateTimePickerFin.Value = DateTime.Today;
            }
        }

        public void MensajeError()
        {
            MessageBox.Show("No hay informe para mostrar para el periodo seleccionado.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
