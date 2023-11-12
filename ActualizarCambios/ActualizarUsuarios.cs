using DB;
using Entidades;
using LecturaEscritura;
using Pagos;
using System.Collections.Generic;
using System.Net;

namespace Actualizar
{
    public class ActualizarUsuarios
    {
       

        public static List<Alumno> ListaAlumnosActuales()
        {
            List<Alumno> usuariosRegistrados = ListaAlumnosActualesBD();
            return usuariosRegistrados;
        }

        public static List<Alumno> ListaAlumnosActualesBD()
        {
            List<Alumno> usuariosRegistrados = CRUDB.ObtenerTodos<Alumno>("Alumno");
            return usuariosRegistrados;
        }

        public static void AgregarAlumnoBD(string file, Alumno nuevoUsuario)
        {
            DataBase.InsertarRegistro<Alumno>(nuevoUsuario);
        }

        public static void AgregarPagosPendientes(ConceptoPagos conceptoPagos, int dniAlumno)
        {
            /* Agrega los pagos pendientes al alumno
             * recibe el concepto de pago a agregar, el dni del alumno que se esta editando
             *  
             */
            
            Alumno alumnoEncontrado = CRUDB.ObtenerPorIdentificador<Alumno>("Alumno", "Dni = @Dni", new { Dni = dniAlumno });

            if (alumnoEncontrado != null)
            {
                List<ConceptoPagos> listaConceptoPagos = string.IsNullOrEmpty(alumnoEncontrado.ConceptoPagos)
                    ? new List<ConceptoPagos>()
                    : CRUD.ConvertirJsonALista<ConceptoPagos>(alumnoEncontrado.ConceptoPagos);

                // Aquí puedes agregar la lógica para crear un nuevo ConceptoPagos si la lista está vacía

                listaConceptoPagos.Add(conceptoPagos);

                alumnoEncontrado.ConceptoPagos = CRUD.ConvertirListaAJson<ConceptoPagos>(listaConceptoPagos);
                string dni = alumnoEncontrado.Dni.ToString();
                CRUDB.ActualizarPorIdentificador("Alumno", "Dni", dni, alumnoEncontrado);
            }






        }



        public static void AgregarCursosAprobados(string codigoCurso, int dniAlumno)
        {
            /* Agrega los pagos pendientes al alumno
             * recibe el concepto de pago a agregar, el dni del alumno que se esta editando
             *  
             */
            Alumno alumnoEncontrado = CRUDB.ObtenerPorIdentificador<Alumno>("Alumno", "Dni = @Dni", new { Dni = dniAlumno });
            
            if (alumnoEncontrado != null)
            {
                List<string> listaCursosAprobados = string.IsNullOrWhiteSpace(alumnoEncontrado.CursosAprobados)
                    ? new List<string>()
                    : CRUD.ConvertirJsonALista<string>(alumnoEncontrado.CursosAprobados);

                listaCursosAprobados.Add(codigoCurso);
                alumnoEncontrado.CursosAprobados = CRUD.ConvertirListaAJson(listaCursosAprobados);

                string dni = alumnoEncontrado.Dni.ToString();
                CRUDB.ActualizarPorIdentificador("Alumno", "Dni", dni, alumnoEncontrado);
            }


        }

        




    }
}