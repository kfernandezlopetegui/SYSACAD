using DB;
using Entidades;
using LecturaEscritura;
using System;
namespace Validaciones
{
    public class ValidarUsuario
    {
        

        public ValidarUsuario()
        {
            CrearTablas();
            CrearUsuariosPorDefecto();
            
            // listaCursos.Add(new Curso("Matematicas","aabc123","Jueves 18:30 a 22:30",5));

            //CRUD.WriteStreamJSON("cursosRegistrados.json", listaCursos);
        }
       

        public async Task<Administrador> VerificarSiExisteAdministradorBD(string usuarioIngresado)
        {


            Administrador administradorEncontrado = await CRUDB.ObtenerPorIdentificadorAsync<Administrador>("Administrador", "Email = @Email", new { Email = usuarioIngresado });


            return administradorEncontrado;

        }
        public async Task<Alumno> VerificarSiExisteAlumnoBD(string usuarioIngresado)
        {
            

            Alumno alumnoEncontrado = await CRUDB.ObtenerPorIdentificadorAsync<Alumno>("Alumno", "Email = @Email", new { Email = usuarioIngresado });


            return alumnoEncontrado;

        }
        public async Task<Alumno> VerificarSiExisteAlumnoBD(int dni)
        {
          

           Alumno alumnoEncontrado = await CRUDB.ObtenerPorIdentificadorAsync<Alumno>("Alumno", "Dni = @Dni", new { Dni = dni });


            return alumnoEncontrado;


        }

        public async Task<int> VerificarUsuario(string usuarioIngresado, string claveIngresada)
        {
            // Utiliza LINQ para buscar un usuario por su correo electrónico
            Administrador usuarioEncontrado = await VerificarSiExisteAdministradorBD(usuarioIngresado);
            Alumno alumnoEncontrado = await VerificarSiExisteAlumnoBD(usuarioIngresado);

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

        public async void CrearUsuariosPorDefecto()
        {

            if (DataBase.VerificarTablaVacia("Administrador"))
            {
                Administrador administrador = new Administrador("Karen", "Fernandez", "Femenino", "admin", Hash.GetHash("admin"), false,
                false, "administrador", "1999,08,28", "Mango", 0000);
                
                await CRUDB.InsertarRegistroAsync<Administrador>(administrador);

            }

            if (DataBase.VerificarTablaVacia("Alumno"))
            {
                Alumno alumno = new Alumno("karen", "fernandez", "Femenino", "karen", Hash.GetHash("1234"), true,
                 false, "estudiante", "1999,08,28", "Mango", 1111, 94298161, "nandubay 123", "1173610818");
                
                await CRUDB.InsertarRegistroAsync<Alumno>(alumno);
            }
        }
        public async void CrearTablas()
        {
            if (DataBase.VerificarBaseDeDatosVacia())
            {
                await CRUDB.CreateTableAsync<Administrador>();
                await CRUDB.CreateTableAsync<Alumno>();
                await CRUDB.CreateTableAsync<Inscripcion>();
                await CRUDB.CreateTableAsync<RequisitosAcademicos>();
                await CRUDB.CreateTableAsync<Curso>();
            }
            
        }


    }
}