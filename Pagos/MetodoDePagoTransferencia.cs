using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagos
{
    public class MetodoDePagoTransferencia
    {
        public string NombreBanco { get; set; }
        public string NumeroCuenta { get; set; }
        public string NombreTitular { get; set; }

        public MetodoDePagoTransferencia(string nombreBanco, string numeroCuenta, string nombreTitular)
        {
            NombreBanco = nombreBanco;
            NumeroCuenta = numeroCuenta;
            NombreTitular = nombreTitular;
        }

        public bool ValidarInformacion()
        {
            
            if (string.IsNullOrEmpty(NombreBanco) || string.IsNullOrEmpty(NumeroCuenta) || string.IsNullOrEmpty(NombreTitular))
            {
                return false;
            }

          

            return true;
        }

        public static bool RealizarTransaccion(decimal monto)
        {
          return true;
        }
    }
}
