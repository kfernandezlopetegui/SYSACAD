using Entidades;
using LecturaEscritura;
using System;
namespace Validaciones
{
    public class ValidarUsuario
    {
        private List<Usuario> listaUsuariosAux = new List<Usuario>();

        private List<Alumno> listaAlumnos = new List<Alumno>();
        private List<Curso> listaCursos = new List<Curso>();
        private string usuarioAdminRuta = "usuarios.json";
        private string alumnosRuta = "alumnosRegistrados.json";

        public ValidarUsuario()
        {
            CrearUsuariosPorDefecto();
            
            // listaCursos.Add(new Curso("Matematicas","aabc123","Jueves 18:30 a 22:30",5));

            //CRUD.WriteStreamJSON("cursosRegistrados.json", listaCursos);
        }
        public Usuario VerificarSiExisteUsuario(string usuarioIngresado)
        {
            // Utiliza LINQ para buscar un usuario por su correo electrónico
            var usuariosRegistrados = CRUD.ReadStreamJSON<Usuario>("usuarios.json");
            
            Usuario ?usuarioEncontrado = usuariosRegistrados.FirstOrDefault(u => u.Email == usuarioIngresado);
            

            return usuarioEncontrado;

           
        }
        public Alumno VerificarSiExisteAlumno(string usuarioIngresado)
        {
            // Utiliza LINQ para buscar un usuario por su correo electrónico
           
            var alumnosRegistrados = CRUD.ReadStreamJSON<Alumno>("alumnosRegistrados.json");

            Alumno? alumnoEncontrado = alumnosRegistrados.FirstOrDefault(u => u.Email == usuarioIngresado);


            return alumnoEncontrado;


        }
        public Alumno VerificarSiExisteAlumno( int dni)
        {
            // Utiliza LINQ para buscar un usuario por su correo electrónico

            var alumnosRegistrados = CRUD.ReadStreamJSON<Alumno>("alumnosRegistrados.json");

            Alumno? alumnoEncontrado = alumnosRegistrados.FirstOrDefault(u => u.Dni == dni);


            return alumnoEncontrado;


        }
        public  int VerificarUsuario(string usuarioIngresado, string claveIngresada)
        {
            // Utiliza LINQ para buscar un usuario por su correo electrónico
            Usuario usuarioEncontrado = VerificarSiExisteUsuario(usuarioIngresado);
            Alumno alumnoEncontrado = VerificarSiExisteAlumno(usuarioIngresado);

            if (usuarioEncontrado != null && Hash.ValidatePassword(claveIngresada, usuarioEncontrado.Clave) && usuarioEncontrado.Rol=="administrador")
            {
                return 1; // admin
            }
            else if (alumnoEncontrado != null && Hash.ValidatePassword(claveIngresada, alumnoEncontrado.Clave) && alumnoEncontrado.Rol == "estudiante")
            {
                return 0; // estudiante
            }

                return -1; // Usuario o contraseña incorrectos
        }

        public void CrearUsuariosPorDefecto()
        {

            if (!CRUD.VerificarSiExisteArchivo(usuarioAdminRuta))
            {
                listaUsuariosAux.Add(new Usuario("Karen", "Fernandez", "Femenino", "admin", Hash.GetHash("admin"), false,
                false,"administrador", "1999,08,28","Mango",LegajoManager.GenerarNuevoLegajo()));
                CRUD.WriteStreamJSON("usuarios.json", listaUsuariosAux);


            }

            if (!CRUD.VerificarSiExisteArchivo(alumnosRuta))
            {

                listaAlumnos.Add(new Alumno("karen", "fernandez", "Femenino", "karen", Hash.GetHash("1234"), true,
                 false, "estudiante", "1999,08,28", "Mango", LegajoManager.GenerarNuevoLegajo(), 94298161, "nandubay 123","1173610818"));
                CRUD.WriteStreamJSON("alumnosRegistrados.json", listaAlumnos);
            }
        }


    }
}