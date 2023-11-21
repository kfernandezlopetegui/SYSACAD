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
        public static List<Profesor> ListaProfesoresActuales()
        {
            List<Profesor> usuariosRegistrados = CRUDB.ObtenerTodos<Profesor>("Profesor");
            return usuariosRegistrados;
        }

        public static List<Alumno> ListaAlumnosActualesBD()
        {
            List<Alumno> usuariosRegistrados = CRUDB.ObtenerTodos<Alumno>("Alumno");
            return usuariosRegistrados;
        }

        public async static void AgregarAlumnoBD( Alumno nuevoUsuario)
        {
           
            await CRUDB.InsertarRegistroAsync<Alumno>(nuevoUsuario);
        }

        public async static void AgregarPagosPendientes(ConceptoPagos conceptoPagos, int dniAlumno)
        {
            /* Agrega los pagos pendientes al alumno
             * recibe el concepto de pago a agregar, el dni del alumno que se esta editando
             *  
             */
            
            Alumno alumnoEncontrado = await CRUDB.ObtenerPorIdentificadorAsync<Alumno>("Alumno", "Dni = @Dni", new { Dni = dniAlumno });

            if (alumnoEncontrado != null)
            {
                List<ConceptoPagos> listaConceptoPagos = string.IsNullOrEmpty(alumnoEncontrado.ConceptoPagos)
                    ? new List<ConceptoPagos>()
                    : CRUD.ConvertirJsonALista<ConceptoPagos>(alumnoEncontrado.ConceptoPagos);

                // Aquí puedes agregar la lógica para crear un nuevo ConceptoPagos si la lista está vacía

                listaConceptoPagos.Add(conceptoPagos);

                alumnoEncontrado.ConceptoPagos = CRUD.ConvertirListaAJson<ConceptoPagos>(listaConceptoPagos);
                string dni = alumnoEncontrado.Dni.ToString();
                await CRUDB.ActualizarPorIdentificadorAsync("Alumno", "Dni", dni, alumnoEncontrado);
            }






        }



        public async static void AgregarCursosAprobados(string codigoCurso, int dniAlumno)
        {
            /* Agrega los pagos pendientes al alumno
             * recibe el concepto de pago a agregar, el dni del alumno que se esta editando
             *  
             */
            Alumno alumnoEncontrado = await CRUDB.ObtenerPorIdentificadorAsync<Alumno>("Alumno", "Dni = @Dni", new { Dni = dniAlumno });
            
            if (alumnoEncontrado != null)
            {
                List<string> listaCursosAprobados = string.IsNullOrWhiteSpace(alumnoEncontrado.CursosAprobados)
                    ? new List<string>()
                    : CRUD.ConvertirJsonALista<string>(alumnoEncontrado.CursosAprobados);

                listaCursosAprobados.Add(codigoCurso);
                alumnoEncontrado.CursosAprobados = CRUD.ConvertirListaAJson(listaCursosAprobados);

                string dni = alumnoEncontrado.Dni.ToString();
                await CRUDB.ActualizarPorIdentificadorAsync("Alumno", "Dni", dni, alumnoEncontrado);
            }


        }

        




    }
}