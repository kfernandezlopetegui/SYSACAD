using Actualizar;
using DB;
using Entidades;
using Interfaces;
using LecturaEscritura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public class EditarProfesorLogica
    {
        private IActualizarProfesor solicitudActualizacion;
        private Profesor profesorActualizar;
        private int dni;
        private string nombre;
        private string apellido;
        private string telefono;
        private string mail;
        private string direccion;
        private string palabraClave;
        private string areasEspecializacion;

        public EditarProfesorLogica(IActualizarProfesor solicitudActualizacion, Profesor profesorActualizar, int dni, string nombre, string apellido, string telefono, string mail, string direccion, string palabraClave, string areasEspecializacion)
        {
            this.solicitudActualizacion = solicitudActualizacion;
            this.profesorActualizar = profesorActualizar;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mail = mail;
            this.direccion = direccion;
            this.palabraClave = palabraClave;
            this.areasEspecializacion = areasEspecializacion;
            this.solicitudActualizacion.ActualizarProfesor += ActualizarProfesor;

        }

        public async void ActualizarProfesor()
        {
            

            Profesor profesor = new Profesor(nombre, apellido, "indefinido", mail, profesorActualizar.Clave, false, false,
                "Profesor", profesorActualizar.FechaDeNacimiento, palabraClave, profesorActualizar.Legajo, dni, direccion, telefono, areasEspecializacion);
        
            await CRUDB.ActualizarPorIdentificadorAsync("Profesor", "Dni", profesorActualizar.Dni, profesor);
            
        }
    }
}
