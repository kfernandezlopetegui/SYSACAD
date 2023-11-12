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
       

        public static void AgregarInscripcion(Inscripcion nuevaInscripcion)
        {
            DataBase.InsertarRegistro<Inscripcion>(nuevaInscripcion);
        }

        public static void EliminarInscripcion(Inscripcion nuevaInscripcion)
        {
            CRUDB.EliminarPorCondicion<Inscripcion>("Inscripcion", "Codigo", nuevaInscripcion.Id);
        }
    }
}
