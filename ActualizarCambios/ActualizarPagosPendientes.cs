using DB;
using Entidades;
using LecturaEscritura;
using Pagos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Actualizar
{
    /// <summary>
    /// Clase que maneja la actualización y gestión de los pagos pendientes de los alumnos.
    /// </summary>
    public class ActualizarPagosPendientes
    {
       
        /// <summary>
        /// Obtiene la lista de conceptos de pagos pendientes para un alumno específico.
        /// </summary>
        /// <param name="dniAlumno">El número de identificación del alumno.</param>
        /// <returns>Una lista de ConceptoPagos que representa los pagos pendientes del alumno.</returns>
        public async static Task<List<ConceptoPagos>> ListaPagosPendientes(int dniAlumno)
        {
           
            
            List<ConceptoPagos> listaConceptoPagos = await CRUDB.ObtenerConceptosPorIdAlumnoAsync(dniAlumno);
           
            

            return listaConceptoPagos;
        }
        /// <summary>
        /// Resta los importes de los conceptos de pagos pendientes del alumno basándose en una lista de ConceptoPagos.
        /// </summary>
        /// <param name="dniAlumno">El número de identificación del alumno.</param>
        /// <param name="listaConceptos">La lista de ConceptoPagos con los importes a restar.</param>
        /// <returns>True si la operación es exitosa; False si hay errores.</returns>
        public async static Task<bool> RestarImportesPagosPendientes(int dniAlumno, List<ConceptoPagos> listaConceptos)
        {
           
           
            //List<ConceptoPagos> listaConceptoPagos = CRUD.ConvertirJsonALista<ConceptoPagos>(alumnoEncontrado.ConceptoPagos);

            List<ConceptoPagos> listaConceptoPagos = await CRUDB.ObtenerConceptosPorIdAlumnoAsync(dniAlumno);

           
                
                foreach (var concepto in listaConceptos)
                {
                    
                    ConceptoPagos conceptoPendiente = listaConceptoPagos.FirstOrDefault(c => c.Concepto == concepto.Concepto);

                    
                    if (conceptoPendiente != null)
                    {
                        
                        conceptoPendiente.MontoPendiente -= concepto.MontoPendiente;

                        
                        if (conceptoPendiente.MontoPendiente <= 0)
                        {
                            conceptoPendiente.MontoPendiente = 0;

                            listaConceptoPagos.RemoveAll(c => c.MontoPendiente == 0);

                        }

                        await CRUDB.ActualizarPorIdentificadorAsync("ConceptoPagos", "Id", conceptoPendiente.Id, conceptoPendiente);
                    }
                    else
                    {
                        
                        return false;
                    }
                }
                
                return true; 
            
                
                
           

        }
    }
}
