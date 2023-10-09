using Entidades;
using LecturaEscritura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actualizar
{
    public class ActualizarInscripciones
    {
        public static List<Inscripcion> ListaInscripcionesActuales(string file)
        {
            List<Inscripcion> inscripcionesRegistrados = CRUD.ReadStreamJSON<Inscripcion>(file);
            return inscripcionesRegistrados;
        }
        public static Inscripcion GetInscripcion(string file,Inscripcion inscripcionIngresada)
        {
            List<Inscripcion> listaInscripciones = ListaInscripcionesActuales(file);
            Inscripcion? inscripcionEncontrado = listaInscripciones.FirstOrDefault(u => u.FechaInscripcion == inscripcionIngresada.FechaInscripcion);
            return inscripcionEncontrado;
        }

        public static void AgregarInscripcion(string file, Inscripcion nuevaInscripcion)
        {
            
            List<Inscripcion> listaInscripciones = ListaInscripcionesActuales(file);

            
            listaInscripciones.Add(nuevaInscripcion);

            
            CRUD.WriteStreamJSON(file, listaInscripciones);
        }
    }
}
