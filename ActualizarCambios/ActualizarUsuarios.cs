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
           
            await CRUDB.InsertarRegistroAsync(nuevoUsuario);
        }

        public async static void AgregarPagosPendientes(ConceptoPagos conceptoPagos)
        {
            /* Agrega los pagos pendientes al alumno
             * recibe el concepto de pago a agregar, el dni del alumno que se esta editando
             *  
             */
            await CRUDB.InsertarRegistroAsync(conceptoPagos);
            

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