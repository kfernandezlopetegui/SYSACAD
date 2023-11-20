using Actualizar;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public class AgregarAlistaEsperaLogica
    {
        private IAgregarAListaEspera _solicitud;
        private Curso _cursoDeListaEspera;
        private Alumno _alumnoSeleccionado;
        public AgregarAlistaEsperaLogica(IAgregarAListaEspera solicitud, Curso cursoDeListaEspera, Alumno alumnoSeleccionado)
        {
            _solicitud = solicitud;
            _cursoDeListaEspera = cursoDeListaEspera;
            _alumnoSeleccionado = alumnoSeleccionado;
            _solicitud.AgregarAListaEspera += AgregarAlumnoAListaEspera;
        }
        public void AgregarAlumnoAListaEspera()
        {
            ListaEspera listaEspera = new ListaEspera(_cursoDeListaEspera.Codigo, _alumnoSeleccionado.Dni);

            ActualizarCurso.AgregarAListaEspera(listaEspera);
        }
    }
}
