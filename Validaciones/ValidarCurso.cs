using Entidades;
using LecturaEscritura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    public class ValidarCurso
    {
        private List<Curso> listaCursos = new List<Curso>();

        public ValidarCurso() { }   

        public static Curso VerificarSiExisteCurso(string codigo)
        {
            // Utiliza LINQ para buscar un usuario por su correo electrónico

            var cursosRegistrados = CRUD.ReadStreamJSON<Curso>("cursosRegistrados.json");

            Curso? cursoEncontrado = cursosRegistrados.FirstOrDefault(u => u.Codigo == codigo);


            return cursoEncontrado;


        }
    }
}
