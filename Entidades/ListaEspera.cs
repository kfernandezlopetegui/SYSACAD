using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ListaEspera
    {
        [PrimaryKeyAtributo]
        public int Id { get; set; }

        public string IdCurso { get; set; }
        public int IdAlumno { get; set; }
        public DateTime FechaSolicitud { get; set; }

        public ListaEspera( string idCurso, int idAlumno)
        {
            Id = Ids.GenerarIdUnico();
            IdCurso = idCurso;
            IdAlumno = idAlumno;
            FechaSolicitud = DateTime.Now;
        }
    }
}
