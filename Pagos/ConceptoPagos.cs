namespace Pagos
{
    public class ConceptoPagos
    {
        public int Id { get; set; }
        public decimal MontoPendiente { get; set; }
        public string Concepto { get; set; }
        public DateTime FechaConcepto { get; set; }

        public ConceptoPagos()
        {
        }

        public ConceptoPagos(decimal montoPendiente, string concepto)
        {
            MontoPendiente = montoPendiente;
            Concepto = concepto;
            FechaConcepto = DateTime.Now;
            Id = 0;
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
    }
}