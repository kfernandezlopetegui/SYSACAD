using Actualizar;
using DB;
using Entidades;
using Interfaces;
using LecturaEscritura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSysacad
{
    public class ActualizarRequisitoLogica
    {
        private Curso cursoDelRequisito;
        private IActualizarRequisito actualizarRequisito;
        private List<string> listaIdCursos;
        private int creditos;
        double promedio;
        private CursoConRequisitos cursoConRequisitos;

        public ActualizarRequisitoLogica(IActualizarRequisito actualizarRequisito, List<string> listaIdCursos,
            Curso cursoDelRequisito, int creditos, double promedio, CursoConRequisitos cursoConRequisitos)
        {
            this.cursoDelRequisito = cursoDelRequisito;
            this.actualizarRequisito = actualizarRequisito;
            this.listaIdCursos = listaIdCursos;
            this.creditos = creditos;
            this.promedio = promedio;
            this.cursoConRequisitos = cursoConRequisitos;
            actualizarRequisito.ActualizarRequisito += ActualizarRequisito;
        }

        public async void ActualizarRequisito()
        {
            string idCursosJson = CRUD.ConvertirListaAJson(listaIdCursos);

            RequisitosAcademicos requisitosAcademicos = new RequisitosAcademicos(idCursosJson, creditos, promedio);
            int idEliminar = cursoDelRequisito.IdRequisitos;
            int idRequisito = requisitosAcademicos.Id;
            cursoDelRequisito.IdRequisitos = idRequisito;

            ActualizarRequisitos.AgregarRequisitos(requisitosAcademicos);
            await CRUDB.ActualizarPorIdentificadorAsync("Curso", "Codigo", cursoConRequisitos.CodigoCurso, cursoDelRequisito);
            ActualizarRequisitos.BorrarRequisitoPorId(idEliminar);
        }
    }
}
