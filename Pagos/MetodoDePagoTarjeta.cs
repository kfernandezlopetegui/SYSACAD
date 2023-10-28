using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pagos
{
    /// <summary>
    /// Representa un método de pago con tarjeta de crédito.
    /// </summary>
    public class MetodoDePagoTarjeta
    {
        public string NumeroTarjeta { get; set; }
        public string NombreTitular { get; set; }
        public string FechaExpiracion { get; set; }
        public string CodigoSeguridad { get; set; }

        public MetodoDePagoTarjeta(string numeroTarjeta, string nombreTitular, string fechaExpiracion, string codigoSeguridad)
        {
            NumeroTarjeta = numeroTarjeta;
            NombreTitular = nombreTitular;
            FechaExpiracion = fechaExpiracion;
            CodigoSeguridad = codigoSeguridad;
        }

        /// <summary>
        /// Procesa un pago con tarjeta de crédito.
        /// </summary>
        /// <param name="monto">Monto del pago a procesar.</param>
        /// <returns>True si el pago se procesa correctamente, false en caso contrario.</returns>
        public static bool ProcesarPago(decimal monto)
        {
            //  lógica para procesar el pago con la tarjeta de crédito.
           
            return true; // Por ahora, asumimos que el pago siempre es exitoso.
        }
        /// <summary>
        /// Verifica si un número de tarjeta de crédito es válido utilizando el algoritmo de Luhn.
        /// </summary>
        /// <param name="numeroTarjeta">Número de la tarjeta de crédito.</param>
        /// <returns>True si el número de tarjeta es válido, false en caso contrario.</returns>
        public static bool EsNumeroTarjetaValido(string numeroTarjeta)
        {
            int sum = 0;
            bool alternate = false;
            char[] digits = numeroTarjeta.ToCharArray();

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(digits[i].ToString());

                if (alternate)
                {
                    digit *= 2;
                    if (digit > 9)
                    {
                        digit -= 9;
                    }
                }

                sum += digit;
                alternate = !alternate;
            }

            return sum % 10 == 0;
        }
        /// <summary>
        /// Verifica si la fecha de expiración de la tarjeta es válida.
        /// </summary>
        /// <param name="fechaExpiracion">Fecha de expiración de la tarjeta en formato MM/yy.</param>
        /// <returns>True si la fecha de expiración es válida, false en caso contrario.</returns>
        public static bool EsFechaExpiracionValida(string fechaExpiracion)
        {
            DateTime fechaActual = DateTime.Now;
            DateTime fechaExpiracionTarjeta;

            if (DateTime.TryParseExact(fechaExpiracion, "MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaExpiracionTarjeta))
            {
                return fechaExpiracionTarjeta > fechaActual;
            }

            return false;
        }

        /// <summary>
        /// Verifica si el código de seguridad (CVV) de la tarjeta es válido.
        /// </summary>
        /// <param name="cvv">Código de seguridad de la tarjeta (CVV).</param>
        /// <returns>True si el CVV es válido, false en caso contrario.</returns>
        public static bool EsCVVValido(string cvv)
        {
            return Regex.IsMatch(cvv, @"^\d{3,4}$");
        }
    }
}
