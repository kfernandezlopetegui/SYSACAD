using Entidades;
using LecturaEscritura;
using Pagos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actualizar
{
    public class ActualizarPagosPendientes
    {
        public static List<ConceptoPagos> ListaPagosPendientes(int dniAlumno)
        {
            List<Alumno> alumnosRegistrados = ActualizarUsuarios.ListaAlumnosActuales();
            Alumno? alumnoEncontrado = alumnosRegistrados.FirstOrDefault(u => u.Dni == dniAlumno);
            List<ConceptoPagos> pagosPendientesRegistrados = new List<ConceptoPagos>();
            if (alumnoEncontrado != null)
            {
                pagosPendientesRegistrados = alumnoEncontrado.ConceptoPagos;
            }
            

            return pagosPendientesRegistrados;
        }
    }
}
