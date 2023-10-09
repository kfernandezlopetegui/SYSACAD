using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pagos
{
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

        public static bool ProcesarPago(decimal monto)
        {
            //  lógica para procesar el pago con la tarjeta de crédito.
           
            return true; // Por ahora, asumimos que el pago siempre es exitoso.
        }

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

        public static bool EsCVVValido(string cvv)
        {
            return Regex.IsMatch(cvv, @"^\d{3,4}$");
        }
    }
}
