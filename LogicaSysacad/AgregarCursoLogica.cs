using Actualizar;
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
    public class AgregarCursoLogica
    {
        private string _idCursosJson;
        private string nombre;
        private string codigo;
        private string descripcion;
        private int cupo;
        private string carrera;
        private int creditos;
        private double promedio;
        public AgregarCursoLogica(IAgregarCurso agregarCurso,string nombre, string codigo, string descripcion,
            int cupo, string carrera, List<string> listaIdCursos, int creditos,
            double promedio)
        {
            _idCursosJson = CRUD.ConvertirListaAJson(listaIdCursos);
            this.nombre = nombre;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.cupo = cupo;
            this.carrera = carrera;
            this.creditos = creditos;
            this.promedio = promedio;
            agregarCurso.CursoAgregar += AgregarCurso;
        }

        public void AgregarCurso()
        {
            RequisitosAcademicos requisitosAcademicos = new RequisitosAcademicos(_idCursosJson, creditos, promedio);

            Curso nuevoCurso = new Curso(nombre, codigo, descripcion, cupo, carrera, requisitosAcademicos.Id);

            ActualizarRequisitos.AgregarRequisitos(requisitosAcademicos);
            ActualizarCurso.AgregarCursoBD(nuevoCurso);

        }
    }
}
