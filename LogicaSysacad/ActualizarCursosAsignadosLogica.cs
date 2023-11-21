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
    public class ActualizarCursosAsignadosLogica
    {
        private IActualizarCursosAsignados solicitud;
        private int idProfesor;
        private List<string> codigosCursos;

        public ActualizarCursosAsignadosLogica(IActualizarCursosAsignados solicitud, int idProfesor, List<string> codigosCursos)
        {
            this.solicitud = solicitud;
            this.idProfesor = idProfesor;
            this.codigosCursos = codigosCursos;
            solicitud.ActualizarCursosAsignados += ActualizarCursosAsignados;
        }

        public async void ActualizarCursosAsignados()
        {
            await CRUDB.EliminarPorCondicionAsync<Curso>("CursosAsignados", "IdProfesor", idProfesor);

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
