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
        public static RequisitosAcademicos ObtenerRequisitos(int id)
        {
           
            RequisitosAcademicos requisitoEncontrado = CRUDB.ObtenerPorIdentificador<RequisitosAcademicos>("RequisitosAcademicos", "Id = @Id", new { Id = id }); ;
            return requisitoEncontrado;
        }

        public static void AgregarRequisitos(RequisitosAcademicos nuevoRequisito)
        {

            DataBase.InsertarRegistro<RequisitosAcademicos>(nuevoRequisito);
        }

        public static void BorrarRequisitoPorId(int id)
        {
            CRUDB.EliminarPorCondicion<Curso>("RequisitosAcademicos", "Id", id);

        }

        public static void EditarRequisito(RequisitosAcademicos requisito, int id)
        {
            /* Edita el curso
             * recibe el curso a guardar, el codigo original del curso que se esta editando
             * y el lugar donde se guarda el archivo para persistir los datos  
             */
            CRUDB.ActualizarPorIdentificador("RequisitosAcademicos", "Id", id, requisito);



        }

    }
}
