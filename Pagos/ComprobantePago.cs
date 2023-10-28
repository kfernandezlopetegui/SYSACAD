using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagos
{
    public class ComprobantePago
    {
        public string NumeroComprobante { get; private set; }
        public DateTime FechaPago { get; private set; }
        public decimal MontoPagado { get; private set; }
        public List<string> ConceptosPago { get; private set; }
        public string MetodoPago { get; private set; }
        public string DetallesTransaccion { get; private set; }

        public ComprobantePago(string numeroComprobante, DateTime fechaPago, decimal montoPagado,
            List<string> conceptosPago, string metodoPago, string detallesTransaccion)
        {
            NumeroComprobante = numeroComprobante;
            FechaPago = fechaPago;
            MontoPagado = montoPagado;
            ConceptosPago = conceptosPago;
            MetodoPago = metodoPago;
            DetallesTransaccion = detallesTransaccion;
        }

        public void MostrarComprobante()
        {
            Console.WriteLine($"Número de Comprobante: {NumeroComprobante}");
            Console.WriteLine($"Fecha de Pago: {FechaPago}");
            Console.WriteLine($"Monto Pagado: {MontoPagado}");
            Console.WriteLine("Conceptos de Pago:");
            foreach (var concepto in ConceptosPago)
            {
                Console.WriteLine($"- {concepto}");
            }
            Console.WriteLine($"Método de Pago: {MetodoPago}");
            Console.WriteLine($"Detalles de la Transacción: {DetallesTransaccion}");
        }

        public string GenerarContenidoComprobante()
        {
            // Generar el contenido del comprobante en formato de texto
            // Puedes formatear el contenido según tus necesidades, por ejemplo:
            StringBuilder contenido = new StringBuilder();
            contenido.AppendLine($"Número de Comprobante: {NumeroComprobante}");
            contenido.AppendLine($"Fecha de Pago: {FechaPago}");
            contenido.AppendLine($"Monto Pagado: {MontoPagado}");
            contenido.AppendLine("Conceptos de Pago:");
            foreach (var concepto in ConceptosPago)
            {
                contenido.AppendLine($"- {concepto}");
            }
            contenido.AppendLine($"Método de Pago: {MetodoPago}");
            contenido.AppendLine($"Detalles de la Transacción: {DetallesTransaccion}");

            return contenido.ToString();
        }

        public void GuardarComoArchivo(string rutaArchivo)
        {
            // Generar el contenido del comprobante
            string contenido = GenerarContenidoComprobante();

            // Escribir el contenido en un archivo
            File.WriteAllText(rutaArchivo, contenido);
        }
        /// <summary>
        /// Genera un número de comprobante único basado en la fecha y hora actuales junto con un número aleatorio.
        /// </summary>
        /// <returns>Número de comprobante único.</returns>
        public static string GenerarNumeroComprobante()
        {
            
            DateTime now = DateTime.Now;

           
            Random random = new Random();
            int numeroAleatorio = random.Next(1000, 10000); 

           
            string numeroComprobante = $"{now.ToString("yyyyMMddHHmmss")}-{numeroAleatorio}";

            return numeroComprobante;
        }
    }

}
