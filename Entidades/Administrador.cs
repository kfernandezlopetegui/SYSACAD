using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Usuario
    {
        public Administrador() : base() { }

        public Administrador(string nombre, string apellido, string sexo, string email, string clave, bool tipoDeClave, bool loginStatus, string nombreRol, string fechaDeNacimiento, string palabraClave, int legajo) : base(nombre, apellido, sexo, email, clave, tipoDeClave, loginStatus, nombreRol, fechaDeNacimiento, palabraClave, legajo)
        {
        }
    }
}
