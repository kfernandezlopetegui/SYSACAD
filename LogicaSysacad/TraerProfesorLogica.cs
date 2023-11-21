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
    public class TraerProfesorLogica
    {
        private ITraerProfesor solicitud;
        private int idProfesor;

        public TraerProfesorLogica(ITraerProfesor solicitud, int idProfesor)
        {
            this.solicitud = solicitud;
            this.idProfesor = idProfesor;
            solicitud.OnProfesorPedido += TraerProfesorPorId;
        }

        public async void TraerProfesorPorId()
        {
            Profesor profesorEncontrado = await CRUDB.ObtenerPorIdentificadorAsync<Profesor>("Profesor", "Dni = @Dni", new { Dni = idProfesor });
            solicitud.CargarDatos(profesorEncontrado);
        }
    }
}
