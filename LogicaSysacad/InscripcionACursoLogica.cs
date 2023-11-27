using Actualizar;
using DB;
using DocumentFormat.OpenXml.Presentation;
using Entidades;
using Interfaces;
using Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public class InscripcionACursoLogica
    {
        IInscripcionCurso solicitud;
        Curso cursoSeleccionado;
        int idAlumno;

        public InscripcionACursoLogica(IInscripcionCurso solicitud, Curso cursoSeleccionado, int idAlumno)
        {
            this.solicitud = solicitud;
            this.cursoSeleccionado = cursoSeleccionado;
            this.idAlumno = idAlumno;
            this.solicitud.InscripcionCurso += RealizarInscripcion;
        }

        public void RealizarInscripcion()
        {
            int idConcepto = DataBase.ObtenerUltimoIdConcepto();
            idConcepto++;
            ConceptoPagos conceptoPagos = new ConceptoPagos(10000, cursoSeleccionado.Nombre, idConcepto,idAlumno, DateTime.Now);
            Inscripcion inscripcion = new Inscripcion(idAlumno, cursoSeleccionado.Codigo);
            ActualizarInscripciones.AgregarInscripcion(inscripcion);
            ActualizarUsuarios.AgregarPagosPendientes(conceptoPagos);

            ActualizarCurso.ActualizarCupo(cursoSeleccionado.Codigo);
        }


    }
}
