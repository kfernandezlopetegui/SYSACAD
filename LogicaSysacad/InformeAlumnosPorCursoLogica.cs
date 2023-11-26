using DB;
using Entidades;
using Interfaces;
using PDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public class InformeAlumnosPorCursoLogica
    {
        IPedirInforme solicitud;
        Curso cursoSeleccionado;

        public InformeAlumnosPorCursoLogica(IPedirInforme solicitud, Curso cursoSeleccionado)
        {
            this.solicitud = solicitud;
            this.cursoSeleccionado = cursoSeleccionado;
            this.solicitud.OnPedirInforme += InformePDF;
        }
        public void InformePDF()
        {
            List<AlumnoInforme> listaAlumnos = CRUDB.ObtenerAlumnosInscritos(cursoSeleccionado.Codigo);
            PDFCursoConEstudiantes.CreatePdf(listaAlumnos, cursoSeleccionado);
        }
    }
}
