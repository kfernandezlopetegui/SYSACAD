using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CursoConRequisitos
    {
        public string NombreCurso { get; set; }
        public string CodigoCurso { get; set; }
        public int CantidadMinimaCreditos { get; set; }
        public double PromedioMinimo { get; set; }
        
        public string NombreCursosCorrelativos { get; set; }
        public string IdCursosCorrelativos { get; set; }

    }
    
}
