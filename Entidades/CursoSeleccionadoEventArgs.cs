using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CursoSeleccionadoEventArgs : EventArgs
    {
        public Curso Curso { get; }

        public CursoSeleccionadoEventArgs(Curso curso)
        {
            Curso = curso;
        }
    }
}
