using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public class TraerPeriodosLogica
    {
        ITraerLista solicitud;

        public TraerPeriodosLogica(ITraerLista solicitud)
        {
            this.solicitud = solicitud;
            this.solicitud.OnListaPedida += TraerLista;
        }

        public List<Periodo> CrearPeriodos()
        {
            List<Semestre> semestres = new List<Semestre>
        {
             new Semestre("Primer Semestre", new List<int> { 1, 2, 3, 4, 5, 6 }),
             new Semestre("Segundo Semestre", new List<int> { 7, 8, 9, 10, 11, 12 })

        };
            List<Periodo> periodos = new List<Periodo>();

            int año = 2023;

            foreach (Semestre semestre in semestres)
            {
                string nombrePeriodo = $"{año} - {semestre.Nombre}";

                // Agregar periodo del primer semestre
                DateTime inicioPrimero = new DateTime(año, semestre.Meses[0], 1);
                DateTime finPrimero = inicioPrimero.AddMonths(6).AddDays(-1);
                periodos.Add(new Periodo(nombrePeriodo, inicioPrimero, finPrimero));

                
            }






            return periodos;

        }
        public void TraerLista()
        {
            solicitud.AsignarLista(CrearPeriodos());
        }
    }
}
