using Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Usuario

    {
        public Alumno() : base()
        {
            
        }
        private int dni;
        
        private string direccion;

        private string telefono;

        private string conceptosDePagos;

        public string CursosAprobados { get; set; }
        public int Creditos { get; set; }
        public double Promedio { get; set; }


        public Alumno(string nombre, string apellido, string sexo, string email, string clave, bool tipoDeClave, bool loginStatus, string nombreRol, string fechaDeNacimiento, string palabraClave,int legajo,  int dni, string direccion, string telefono, string cursosAProbados) : base(nombre, apellido, sexo, email, clave, tipoDeClave, loginStatus, nombreRol, fechaDeNacimiento, palabraClave, legajo)
        {
            this.dni = dni;
           
            this.direccion = direccion;

            this.telefono = telefono;

            this.conceptosDePagos =  "";
            this.CursosAprobados = cursosAProbados;
            this.Promedio = 4;
            this.Creditos = 400;

        }

       
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }

        }

        public string Telefono
        {
            get { return telefono; }   
            set { telefono = value; }
        }
        public string ConceptoPagos
        {
            get { return conceptosDePagos; }
            set { conceptosDePagos = value; }
        }
       
    }
}
