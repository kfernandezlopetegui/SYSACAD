using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SolicitudListaEsperaDetallada
    {
        public int IdSolicitud { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string NombreCurso { get; set; }
        public string IdCurso { get; set; }
        public string NombreAlumno { get; set; }
        public string ApellidoAlumno { get; set; }
        public int LegajoAlumno { get; set; }
        public int IdAlumno { get; set; }



        public SolicitudListaEsperaDetallada(int idSolicitud, DateTime fechaSolicitud,
    int idAlumno, string nombreAlumno, string apellidoAlumno, int legajoAlumno,
    string idCurso, string nombreCurso)
        {
            IdSolicitud = idSolicitud;
            FechaSolicitud = fechaSolicitud;
            IdAlumno = idAlumno;
            NombreAlumno = nombreAlumno;
            ApellidoAlumno = apellidoAlumno;
            LegajoAlumno = legajoAlumno;
            IdCurso = idCurso;
            NombreCurso = nombreCurso;
        }


        public SolicitudListaEsperaDetallada()
        {
        }
    }
}
