using DB;
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
        public static List<Inscripcion> ListaInscripcionesActuales()
        {
            List<Inscripcion> inscripcionesRegistrados = CRUDB.ObtenerTodos<Inscripcion>("Inscripcion");
            return inscripcionesRegistrados;
        }
       

        public async static void AgregarInscripcion(Inscripcion nuevaInscripcion)
        {
           
            await CRUDB.InsertarRegistroAsync<Inscripcion>(nuevaInscripcion);

        }

        public async static void EliminarInscripcion(Inscripcion nuevaInscripcion)
        {
            await CRUDB.EliminarPorCondicionAsync<Inscripcion>("Inscripcion", "Codigo", nuevaInscripcion.Id);
        }
    }
}
