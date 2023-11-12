using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CursoViewModel
    {
        public string NombreConCodigo { get; set; }
        public int Id { get; set; }

        public CursoViewModel(string nombreConCodigo, int id)
        {
            NombreConCodigo = nombreConCodigo;
            Id = id;
        }
    }
}
