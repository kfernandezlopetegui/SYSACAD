using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class InscripcionInfo : Inscripcion
    {
        
        
        public string AlumnoNombre { get; set; }
        public string AlumnoApellido { get; set; }

        public string CursoNombre { get; set; }
        public string Carrera { get; set; }

        public new  DateTime  FechaInscripcion { get; set; }


        public InscripcionInfo() : base()
        {
        }

        public InscripcionInfo(int alumnoId, string cursoId, string alumnoNombre, string alumnoApellido, string cursoNombre, DateTime fechaInscripcion) : base(alumnoId, cursoId)
        {
            AlumnoNombre = alumnoNombre;
            AlumnoApellido = alumnoApellido;
            CursoNombre = cursoNombre;
            FechaInscripcion = fechaInscripcion;
        }

       
    }
}
