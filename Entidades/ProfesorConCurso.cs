using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProfesorConCurso
    {
        public int Legajo { get; set; }
        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string NumeroTelefono { get; set; }
        public string AreasEspecializacion { get; set; }
        public string CursosAsignados { get; set; }
       

        public ProfesorConCurso(int idProfesor, string nombre, string apellido, string direccion, string email, string numeroTelefono, string areasEspecializacion, string cursosAsignados, int legajo)
        {
            IdProfesor = idProfesor;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Email = email;
            NumeroTelefono = numeroTelefono;
            AreasEspecializacion = areasEspecializacion;
            CursosAsignados = cursosAsignados;
            Legajo = legajo;
        }

        public ProfesorConCurso()
        {
        }
    }
}
