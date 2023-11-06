using Entidades;
using LecturaEscritura;
using Pagos;
using System.Collections.Generic;

namespace Actualizar
{
    public class ActualizarUsuarios
    {
        public static List<Usuario> ListaUsuariosActuales()
        {
            List<Usuario> usuariosRegistrados = CRUD.ReadStreamJSON<Usuario>("usuarios.json");
            return usuariosRegistrados;
        }

        public static List<Alumno> ListaAlumnosActuales()
        {
            List<Alumno> usuariosRegistrados = CRUD.ReadStreamJSON<Alumno>("alumnosRegistrados.json");
            return usuariosRegistrados;
        }
        public static void AgregarAlumno(string file, Alumno nuevoUsuario)
        {
            // Leer la lista existente desde el archivo JSON
            List<Alumno> listaUsuarios = CRUD.ReadStreamJSON<Alumno>(file);

            // Agregar el nuevo usuario a la lista
            listaUsuarios.Add(nuevoUsuario);

            // Escribir la lista actualizada en el archivo JSON
            CRUD.WriteStreamJSON(file, listaUsuarios);
        }

        public static void AgregarPagosPendientes(ConceptoPagos conceptoPagos, int dniAlumno)
        {
            /* Agrega los pagos pendientes al alumno
             * recibe el concepto de pago a agregar, el dni del alumno que se esta editando
             *  
             */
            List<Alumno> alumnosRegistrados = ListaAlumnosActuales();
            Alumno ?alumnoEncontrado = alumnosRegistrados.FirstOrDefault(u => u.Dni == dniAlumno);
           
            if (alumnoEncontrado != null)
            {

                List<ConceptoPagos> listaConceptoPagos = CRUD.ConvertirJsonALista<ConceptoPagos>(alumnoEncontrado.ConceptoPagos);
                listaConceptoPagos.Add(conceptoPagos);
                alumnoEncontrado.ConceptoPagos = CRUD.ConvertirListaAJson<ConceptoPagos>(listaConceptoPagos);
                CRUD.WriteStreamJSON("alumnosRegistrados.json", alumnosRegistrados);
            }
            
            

            
        }

        public static void AgregarCursosAprobados(string codigoCurso, int dniAlumno)
        {
            /* Agrega los pagos pendientes al alumno
             * recibe el concepto de pago a agregar, el dni del alumno que se esta editando
             *  
             */
            List<Alumno> alumnosRegistrados = ListaAlumnosActuales();
            Alumno? alumnoEncontrado = alumnosRegistrados.FirstOrDefault(u => u.Dni == dniAlumno);
            List<string> listaCursosAprobados = CRUD.ConvertirJsonALista(alumnoEncontrado.CursosAprobados);
            if (alumnoEncontrado != null)
            {


                listaCursosAprobados.Add(codigoCurso);
                alumnoEncontrado.CursosAprobados = CRUD.ConvertirListaAJson(listaCursosAprobados);

                CRUD.WriteStreamJSON("alumnosRegistrados.json", alumnosRegistrados);
            }


        }

        


    }
}