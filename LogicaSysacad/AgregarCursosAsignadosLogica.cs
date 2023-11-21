using DB;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public class AgregarCursosAsignadosLogica
    {
        private IAsignarCursos solicitud;
        private int idProfesor;
        private List<string> codigosCursos;

        public AgregarCursosAsignadosLogica(IAsignarCursos solicitud, int idProfesor, List<string> codigosCursos)
        {
            this.solicitud = solicitud;
            this.idProfesor = idProfesor;
            this.codigosCursos = codigosCursos;
            this.solicitud.AsignarCursos += CrearCursosAsignados;
        }

        public async void CrearCursosAsignados()
        {
           
            if (codigosCursos.Count > 0)
            {
                foreach (string codigoCurso in codigosCursos)
                {
                    CursosAsignados cursoAsignado = new CursosAsignados(codigoCurso, idProfesor);
                    await CRUDB.InsertarRegistroAsync(cursoAsignado);
                }
            }
            

            
        }
    }
}
