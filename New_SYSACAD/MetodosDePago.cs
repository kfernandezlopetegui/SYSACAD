﻿using Actualizar;
using Login;
using Pagos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace New_SYSACAD
{
    /// <summary>
    /// Clase parcial que representa el formulario de métodos de pago para realizar transacciones.
    /// </summary>
    public partial class MetodosDePago : Form
    {
        private string? numeroDeTarjeta;
        private string? nombreTitularTarjeta;
        private string? fechaDeExpiracion;
        private string? cvc;
        private string? numeroDeCuenta;
        private string? nombreDeBanco;
        private string? nombreTitularBanco;
        private double montoDePago;
        private List<string> conceptoPagos;
        private List<ConceptoPagos> conceptoPagosSeleccionados;
        private DateTime fechaPago = DateTime.Now;
        public MetodosDePago(double montoDePago, List<ConceptoPagos> conceptoPagos)
        {
            InitializeComponent();
            this.montoDePago = montoDePago;
            this.conceptoPagos = ConceptoPagos.ConvertirConceptosAStrings(conceptoPagos);
            conceptoPagosSeleccionados = conceptoPagos;
        }
        
        private void textBoxNumeroTarjeta_Validated(object sender, EventArgs e)
        {
            ControlForm.ValidarCampoNoVacio(textBoxNumeroTarjeta, "El numero de tarjeta");

            if (MetodoDePagoTarjeta.EsNumeroTarjetaValido(textBoxNumeroTarjeta.Text))
            {
                numeroDeTarjeta = textBoxNumeroTarjeta.Text;
            }
            else
            {
                ControlForm.MostrarError(textBoxNumeroTarjeta, "El numero de tarjeta", "no es válido!");
            }


        }

        private void textBoxNombreTitularTarjeta_Validated(object sender, EventArgs e)
        {
            if (ControlForm.ValidarCampoNoVacio(textBoxNombreTitularTarjeta, "Nombre del titular"))
            {
                nombreTitularTarjeta = textBoxNombreTitularTarjeta.Text;
            }


        }

        private void textBoxFechaExpiracion_Validated(object sender, EventArgs e)
        {
            ControlForm.ValidarCampoNoVacio(textBoxFechaExpiracion, "Fecha de expiracion");

            if (MetodoDePagoTarjeta.EsFechaExpiracionValida(textBoxFechaExpiracion.Text))
            {
                fechaDeExpiracion = textBoxFechaExpiracion.Text;
            }
            else
            {
                ControlForm.MostrarError(textBoxFechaExpiracion, "La fecha de expiracion", "no es válida!");
            }
        }

        private void textBoxCvc_Validated(object sender, EventArgs e)
        {
            ControlForm.ValidarCampoNoVacio(textBoxCvc, "Codigo CVC");

            if (MetodoDePagoTarjeta.EsCVVValido(textBoxCvc.Text))
            {
                cvc = textBoxCvc.Text;
            }
            else
            {
                ControlForm.MostrarError(textBoxCvc, "Codigo CVC", "no es válido!");
            }
        }

        private void textBoxNumeroCuenta_Validated(object sender, EventArgs e)
        {

            if (ControlForm.ValidarCampoNoVacio(textBoxNumeroCuenta, "Numero de cuenta"))
            {
                numeroDeCuenta = textBoxNumeroCuenta.Text;
            }
        }

        private void textBoxNombreBanco_Validated(object sender, EventArgs e)
        {
            if (ControlForm.ValidarCampoNoVacio(textBoxNombreBanco, "Nombre del banco"))
            {
                nombreDeBanco = textBoxNombreBanco.Text;
            }
        }

        private void textBoxNombreTitular_Validated(object sender, EventArgs e)
        {
            if (ControlForm.ValidarCampoNoVacio(textBoxNombreTitular, "Nombre del titular"))
            {
                nombreTitularBanco = textBoxNombreTitular.Text;
            }
        }

        /// <summary>
        /// Valida y procesa el pago cuando se hace clic en el botón de Pagar.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void buttonPagar_Click(object sender, EventArgs e)
        {

            TabPage pestañaSeleccionada = tabControl1.SelectedTab;
            bool datosTarjetaCompletos = numeroDeTarjeta != null && nombreTitularTarjeta != null && fechaDeExpiracion != null && cvc != null;
            bool datosBancariosCompletos = numeroDeCuenta != null && nombreTitularBanco != null && nombreDeBanco != null;

            if (pestañaSeleccionada == tabPageTarjeta && datosTarjetaCompletos)
            {
                if (MetodoDePagoTarjeta.ProcesarPago(montoDePago))
                {
                    MessageBox.Show("Operación completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ComprobantePago comprobantePago = new ComprobantePago(ComprobantePago.GenerarNumeroComprobante(), fechaPago, montoDePago, conceptoPagos, "Pago por tarjeta", ObtenerDescripcionTransaccionTarjeta());
                    FormComprobantePago formComprobantePago = new FormComprobantePago(comprobantePago);
                    ActualizarPagosPendientes.RestarImportesPagosPendientes(SesionAlumno.AlumnoActual.Dni, conceptoPagosSeleccionados);
                    Menu.MostrarMenu(formComprobantePago, this, 1);
                }

            }
            else if (pestañaSeleccionada == tabPageCuentaBancaria && datosBancariosCompletos)
            {
                if (MetodoDePagoTransferencia.RealizarTransaccion(montoDePago))
                {
                    MessageBox.Show("Operación completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ComprobantePago comprobantePago = new ComprobantePago(ComprobantePago.GenerarNumeroComprobante(), fechaPago, montoDePago, conceptoPagos, "Pago por datos bancarios", ObtenerDescripcionTransaccionCuenta());
                    FormComprobantePago formComprobantePago = new FormComprobantePago(comprobantePago);
                    ActualizarPagosPendientes.RestarImportesPagosPendientes(SesionAlumno.AlumnoActual.Dni, conceptoPagosSeleccionados);
                    Menu.MostrarMenu(formComprobantePago, this, 1);
                }
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error. Por favor, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        /// <summary>
        /// Obtiene la descripción detallada de la transacción cuando se utiliza la opción de cuenta bancaria.
        /// </summary>
        /// <returns>Descripción detallada de la transacción.</returns>
        public string ObtenerDescripcionTransaccionCuenta()
        {
            return $"Número de Cuenta: {numeroDeCuenta}\nTitular: {nombreTitularBanco}\nBanco: {nombreDeBanco}";
        }
        /// <summary>
        /// Obtiene la descripción detallada de la transacción cuando se utiliza la opción de cuenta bancaria.
        /// </summary>
        /// <returns>Descripción detallada de la transacción.</returns>
        public string ObtenerDescripcionTransaccionTarjeta()
        {
            return $"Número de Tarjeta: {numeroDeTarjeta}\nTitular: {nombreTitularTarjeta}";
        }
        /// <summary>
        /// Maneja el evento de clic en el botón Cancelar para regresar al menú principal del estudiante.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MenuEstudiante menuEstudiante = new MenuEstudiante();
            Menu.MostrarMenu(menuEstudiante, this, 1);
        }
    }
}
