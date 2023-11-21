using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor: Usuario
    {
        public int Dni { get; set; }
        public string Direccion { get; set; }
        public string NumeroTelefono { get; set; }
        public string AreasEspecializacion { get; set; }
        

        public Profesor(string nombre, string apellido, string sexo, string email, string clave, bool tipoDeClave, bool loginStatus, string nombreRol, string fechaDeNacimiento, string palabraClave, int legajo, int dni, string direccion, string numeroTelefono, string areasEspecializacion):base(nombre, apellido, sexo, email, clave, tipoDeClave, loginStatus, nombreRol, fechaDeNacimiento, palabraClave, legajo)
        {
            Direccion = direccion;
            NumeroTelefono = numeroTelefono;
            AreasEspecializacion = areasEspecializacion;
            
            Dni= dni;
        }

        public Profesor():base()
        {

        }
        
    }

}
