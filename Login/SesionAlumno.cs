using Entidades;

namespace Login
{
    public static class SesionAlumno
    {
        public static Alumno ?AlumnoActual { get; set; }

        public static void IniciarSesion(Alumno alumno)
        {
            AlumnoActual = alumno;
        }

        public static void CerrarSesion()
        {
            AlumnoActual = null;
        }
    }
}