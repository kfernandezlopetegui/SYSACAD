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
    public class EliminarProfesorLogica
    {
        private IEliminarEleccionLE _solicitud;
        private ProfesorConCurso seleccion;

        public EliminarProfesorLogica(IEliminarEleccionLE solicitud, ProfesorConCurso seleccion)
        {
            _solicitud = solicitud;
            this.seleccion = seleccion;
            _solicitud.EliminarEleccion += EliminarEleccion;
        }
        public async void EliminarEleccion()
        {
            await CRUDB.EliminarPorCondicionAsync<Profesor>("Profesor", "Legajo", seleccion.Legajo);
            await CRUDB.EliminarPorCondicionAsync<CursosAsignados>("CursosAsignados", "IdProfesor", seleccion.IdProfesor);
        }
    }
}
