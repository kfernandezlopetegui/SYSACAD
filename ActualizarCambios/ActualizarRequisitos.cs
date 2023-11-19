using DB;
using Entidades;
using LecturaEscritura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actualizar
{
    public class ActualizarRequisitos
    {
        public static List<RequisitosAcademicos> ListaRequisitosActuales()
        {
            List<RequisitosAcademicos> requisitosRegistrados = CRUDB.ObtenerTodos<RequisitosAcademicos>("RequisitosAcademicos");
            return requisitosRegistrados;
        }
        public async static Task<RequisitosAcademicos> ObtenerRequisitos(int id)
        {
           
            RequisitosAcademicos requisitoEncontrado = await CRUDB.ObtenerPorIdentificadorAsync<RequisitosAcademicos>("RequisitosAcademicos", "Id = @Id", new { Id = id }); ;
            return requisitoEncontrado;
        }

        public async static void AgregarRequisitos(RequisitosAcademicos nuevoRequisito)
        {

            
            await CRUDB.InsertarRegistroAsync<RequisitosAcademicos>(nuevoRequisito);
        }

        public async static void BorrarRequisitoPorId(int id)
        {
            await CRUDB.EliminarPorCondicionAsync<Curso>("RequisitosAcademicos", "Id", id);

        }

        public async static void EditarRequisito(RequisitosAcademicos requisito, int id)
        {
            /* Edita el curso
             * recibe el curso a guardar, el codigo original del curso que se esta editando
             * y el lugar donde se guarda el archivo para persistir los datos  
             */
            await CRUDB.ActualizarPorIdentificadorAsync("RequisitosAcademicos", "Id", id, requisito);



        }

    }
}
