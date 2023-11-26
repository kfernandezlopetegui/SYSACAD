using DB;
using Entidades;
using Interfaces;
using PDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public  class InformeEstadisticasInscripcionPorCarreraLogica
    {

        IPedirInforme solicitud;
        Periodo periodo;

        public InformeEstadisticasInscripcionPorCarreraLogica(IPedirInforme solicitud, Periodo periodo)
        {
            this.solicitud = solicitud;
            this.periodo = periodo;
            this.solicitud.OnPedirInforme += TraerInformePdf;
        }

        public static List<EstadisticasPorCarrera> ObtenerEstadisticasPorCarrera(List<InscripcionInfo> inscripciones)
        {
            // Agrupa las inscripciones por carrera y cuenta la cantidad en cada grupo
            var estadisticas = inscripciones
                .GroupBy(inscripcion => inscripcion.Carrera)
                .Select(grupo => new EstadisticasPorCarrera
                {
                    Carrera = grupo.Key,
                    CantidadInscripciones = grupo.Count(),
                    PorcentajeInscripciones = 0 // Inicialmente, el porcentaje se establece en 0
                })
                .ToList();

            // Calcular el total de inscripciones
            int totalInscripciones = estadisticas.Sum(estadistica => estadistica.CantidadInscripciones);

            // Calcular el porcentaje de inscripciones para cada carrera
            foreach (var estadistica in estadisticas)
            {
                double porcentaje = (double)estadistica.CantidadInscripciones / totalInscripciones * 100;
                estadistica.PorcentajeInscripciones = Math.Round(porcentaje, 2);
            }

            return estadisticas;
        }


        public void TraerInformePdf()
        {
            List<InscripcionInfo> inscripciones = CRUDB.ObtenerInscripcionesEnPeriodo(periodo);
            if (inscripciones == null || inscripciones.Count == 0)
            {
                solicitud.MensajeError(); return;
            }
            else
            {
                List<EstadisticasPorCarrera> listaEstadisticaPorCarrera = ObtenerEstadisticasPorCarrera(inscripciones);

                PDFEstadisticasPorCarrera.CreatePdf(inscripciones, periodo, listaEstadisticaPorCarrera);
            }
               
           
        }
    }
}
