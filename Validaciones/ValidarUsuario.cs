using DB;
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
            CrearTablas();
            CrearUsuariosPorDefecto();
            
            // listaCursos.Add(new Curso("Matematicas","aabc123","Jueves 18:30 a 22:30",5));

            //CRUD.WriteStreamJSON("cursosRegistrados.json", listaCursos);
        }
       

        public Administrador VerificarSiExisteAdministradorBD(string usuarioIngresado)
        {


            Administrador alumnoEncontrado = CRUDB.ObtenerPorIdentificador<Administrador>("Administrador", "Email = @Email", new { Email = usuarioIngresado });


            return alumnoEncontrado;

        }
        public Alumno VerificarSiExisteAlumnoBD(string usuarioIngresado)
        {
            

            Alumno alumnoEncontrado = CRUDB.ObtenerPorIdentificador<Alumno>("Alumno", "Email = @Email", new { Email = usuarioIngresado });


            return alumnoEncontrado;

        }
        public Alumno VerificarSiExisteAlumnoBD(int dni)
        {
          

           Alumno alumnoEncontrado = CRUDB.ObtenerPorIdentificador<Alumno>("Alumno", "Dni = @Dni", new { Dni = dni });


            return alumnoEncontrado;


        }

        public  int VerificarUsuario(string usuarioIngresado, string claveIngresada)
        {
            // Utiliza LINQ para buscar un usuario por su correo electrónico
            Administrador usuarioEncontrado = VerificarSiExisteAdministradorBD(usuarioIngresado);
            Alumno alumnoEncontrado = VerificarSiExisteAlumnoBD(usuarioIngresado);

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

            if (DataBase.VerificarTablaVacia("Administrador"))
            {
                Administrador administrador = new Administrador("Karen", "Fernandez", "Femenino", "admin", Hash.GetHash("admin"), false,
                false, "administrador", "1999,08,28", "Mango", 0000);
                DataBase.InsertarRegistro<Administrador>(administrador);

            }

            if (DataBase.VerificarTablaVacia("Alumno"))
            {
                Alumno alumno = new Alumno("karen", "fernandez", "Femenino", "karen", Hash.GetHash("1234"), true,
                 false, "estudiante", "1999,08,28", "Mango", 1111, 94298161, "nandubay 123", "1173610818");
                DataBase.InsertarRegistro<Alumno>(alumno);
            }
        }
        public void CrearTablas()
        {
            if (DataBase.VerificarBaseDeDatosVacia())
            {
                DataBase.CreateTable<Administrador>();
                DataBase.CreateTable<Alumno>();
                DataBase.CreateTable<Inscripcion>();
                DataBase.CreateTable<RequisitosAcademicos>();
                DataBase.CreateTable<Curso>();
            }
            
        }


    }
}