using Actualizar;
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
    public class EliminarCursoLogica
    {
        private IEliminarCurso _eliminarCurso;
        private Curso _cursoSeleccionado;
        public EliminarCursoLogica(IEliminarCurso eliminarCurso, Curso cursoSeleccionado)
        {
            _eliminarCurso = eliminarCurso;
            _cursoSeleccionado = cursoSeleccionado;
            _eliminarCurso.BorrarCurso += BorrarCurso;
        }

        public async void BorrarCurso()
        {
            
            int idRequisitoEliminar = _cursoSeleccionado.IdRequisitos;
            ActualizarCurso.BorrarCursoPorCodigoBD(_cursoSeleccionado.Codigo);
            ActualizarRequisitos.BorrarRequisitoPorId(idRequisitoEliminar);
            await CRUDB.EliminarPorCondicionAsync<Curso>("CursosAsignados", "IdCurso", _cursoSeleccionado.Codigo);

        }
    }
}
