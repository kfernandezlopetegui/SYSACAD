using Entidades;

namespace Pagos
{
    public class ConceptoPagos
    {
        public int Id { get; set; }
        public double MontoPendiente { get; set; }
        public string Concepto { get; set; }
        public DateTime FechaConcepto { get; set; }
        public DateTime Vencimiento { get; set; }
        public int IdAlumno { get; set; }
        
        public ConceptoPagos()
        {
        }

        public ConceptoPagos(double montoPendiente, string concepto, int id, int idAlumno,DateTime fechaConcepto)
        {
            MontoPendiente = montoPendiente;
            Concepto = concepto;
            FechaConcepto = fechaConcepto;
            Id = id;
            IdAlumno = idAlumno;
            Vencimiento = CalcularVencimiento();
        }

        public override string ToString()
        {
            return $"{Concepto}, Monto: ${MontoPendiente}";
        }
        public static List<string> ConvertirConceptosAStrings(List<ConceptoPagos> conceptos)
        {
            List<string> conceptosStrings = new List<string>();

            foreach (var concepto in conceptos)
            {
                string conceptoString = concepto.ToString();
                conceptosStrings.Add(conceptoString);
            }

            return conceptosStrings;
        }
        public DateTime CalcularVencimiento()
        {
            // Supongamos que el vencimiento es 5 minutos después de la fecha del concepto
            return FechaConcepto.AddMinutes(5);
        }

        public string ObtenerMensajeSeguimiento()
        {
            
            DateTime ahora = DateTime.Now;

            // Calcula la diferencia en minutos entre la fecha actual y el vencimiento
            int minutosRestantes = (int)(Vencimiento - ahora).TotalMinutes;

            if (minutosRestantes > 0)
            {
                // Si faltan más de 0 minutos, aún no ha vencido
                return $"El concepto {Concepto} vencerá en {minutosRestantes} minutos.";
            }
            else if (minutosRestantes == 0)
            {
                // Si faltan 0 minutos, está venciendo en este momento
                return $"¡El concepto {Concepto} está venciendo ahora!";
            }
            else
            {
                // Si minutosRestantes es negativo, ya ha vencido
                return $"El concepto {Concepto} ha vencido.";
            }
        }

        public Notificacion GenerarNotificacion()
        {
            // Lógica para determinar si debe generarse una notificación
            DateTime fechaActual = DateTime.Now;

            if (fechaActual > Vencimiento)
            {
                int idNotificacion = Id + 5000;
                string mensaje = $"El concepto de pago '{Concepto}' se ha vencido. Monto pendiente: ${MontoPendiente}.";
                return new Notificacion(idNotificacion,IdAlumno, mensaje,false);
            }
            else if (fechaActual.AddMinutes(3) >= Vencimiento)
            {
                int idNotificacion = Id + 5000;
                string mensaje = $"El concepto de pago '{Concepto}' se esta por vencer Monto pendiente: ${MontoPendiente}.";
                return new Notificacion(idNotificacion, IdAlumno, mensaje, false);
            }

            

            return null; // No se genera notificación
        }
    }
}