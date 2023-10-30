using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private string nombre;
        private string codigo;
        private string descripcion;
        private int cupoMaximo;
        private int cupoActual;
        private string carrera;
        private int idRequisitos;

        public Curso() { }

        public Curso(string nombre, string codigo, string descripcion, int cupoMaximo, string carrera, int idRequisitos)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.cupoMaximo = cupoMaximo;
            this.carrera = carrera;
            this.idRequisitos = idRequisitos;
            
        }

        public string Nombre
        {
            get { return nombre; }  
            set { nombre = value; }
        }

        public string Codigo { get { return codigo; } set { codigo = value; } }

        public string Descripcion { get {  return descripcion; } set {  descripcion = value; } }

        public int CupoMaximo { get {  return cupoMaximo; } set {  cupoMaximo = value; } }

        public int CupoActual { get {  return cupoActual; } set { cupoActual= value; } }

        public string Carrera { get {  return carrera; } set {  carrera = value; } }
        public int IdRequisitos { get { return idRequisitos; }set { idRequisitos = value; } }
        public void SumarInscripto()
        {
            cupoActual ++;
        }
    }
}
