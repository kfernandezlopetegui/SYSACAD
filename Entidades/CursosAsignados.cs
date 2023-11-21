using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CursosAsignados
    {
        [PrimaryKeyAtributo]
        public int Id { get; set; }

        public string IdCurso { get; set; }
        public int IdProfesor { get; set; }

        public CursosAsignados(string idCurso, int idProfesor)
        {
            Id = Ids.GenerarIdUnico();
            IdCurso = idCurso;
            IdProfesor = idProfesor;
        }
    }
}
