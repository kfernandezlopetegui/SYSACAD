using DB;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public class AgregarProfesorLogica
    {
        private IAgregarProfesor solicitud;
        private int dni ;
        private string nombre ;
        private string apellido ;
        private string telefono ;
        private string mail ;
        private string direccion;
        private string contraseñaP;
        private string palabraClave ;
        private string fechaNacimiento ;
        private string areasEspecializacion;

        public AgregarProfesorLogica(IAgregarProfesor solicitud, int dni, string nombre, string apellido, string telefono, string mail, string direccion, string contraseñaP, string palabraClave, string fechaNacimiento, string areasEspecializacion)
        {
            this.solicitud = solicitud;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mail = mail;
            this.direccion = direccion;
            this.contraseñaP = contraseñaP;
            this.palabraClave = palabraClave;
            this.fechaNacimiento = fechaNacimiento;
            this.areasEspecializacion = areasEspecializacion;
            
            solicitud.AgregarProfe += AgregarProfesor;
        }
        public async void AgregarProfesor()
        {
            int legajo = DataBase.ObtenerUltimoLegajoProfesor();
            legajo++;
            Profesor profesor = new Profesor(nombre, apellido, "indefinido",mail, contraseñaP, false, false,
                "Profesor",fechaNacimiento, palabraClave, legajo, dni, direccion, telefono, areasEspecializacion);
            await CRUDB.InsertarRegistroAsync<Profesor>(profesor);
        }
    }
}
