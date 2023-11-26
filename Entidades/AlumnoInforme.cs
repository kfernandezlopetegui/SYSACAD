using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlumnoInforme
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }

        public AlumnoInforme(int dni, string nombre, string apellido, string email)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
        }

        public AlumnoInforme()
        {
        }
    }
}
