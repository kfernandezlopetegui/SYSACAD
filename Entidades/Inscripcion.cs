using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inscripcion
    {
        public int AlumnoId { get; set; }
        public string CursoId { get; set; }
        public DateTime FechaInscripcion { get; set; }

        public Inscripcion()
        {
        }

        public Inscripcion(int alumnoId, string cursoId)
        {
            AlumnoId = alumnoId;
            CursoId = cursoId;
            FechaInscripcion = DateTime.Now;
        }
    }
}
