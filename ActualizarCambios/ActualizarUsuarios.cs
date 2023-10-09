using Entidades;
using LecturaEscritura;


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
            List<Alumno> usuariosRegistrados = CRUD.ReadStreamJSON<Alumno>("usuarios.json");
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

    

    }
}