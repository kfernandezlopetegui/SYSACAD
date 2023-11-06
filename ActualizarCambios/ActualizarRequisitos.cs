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
        public static List<RequisitosAcademicos> ListaRequisitosActuales(string file)
        {
            List<RequisitosAcademicos> requisitosRegistrados = CRUD.ReadStreamJSON<RequisitosAcademicos>(file);
            return requisitosRegistrados;
        }
        public static RequisitosAcademicos ObtenerRequisitos(string file, int id)
        {
            List<RequisitosAcademicos> listaRequisitos = ListaRequisitosActuales(file);
            RequisitosAcademicos? requisitoEncontrado = listaRequisitos.FirstOrDefault(u => u.Id == id);
            return requisitoEncontrado;
        }

        public static void AgregarRequisitos(string file, RequisitosAcademicos nuevoRequisito)
        {
            
            List<RequisitosAcademicos> listaRequisitos = ListaRequisitosActuales(file);
           
            listaRequisitos.Add(nuevoRequisito);

            CRUD.WriteStreamJSON(file, listaRequisitos);
        }

        public static void BorrarRequisitoPorId(int id, string file)
        {
            List<RequisitosAcademicos> listaRequisitos = ListaRequisitosActuales(file);
            RequisitosAcademicos? requisitoEncontrado = listaRequisitos.FirstOrDefault(u => u.Id == id);
            listaRequisitos.Remove(requisitoEncontrado);
            CRUD.WriteStreamJSON(file, listaRequisitos);

        }

        public static void EditarRequisito(RequisitosAcademicos requisito, string file, int id)
        {
            /* Edita el curso
             * recibe el curso a guardar, el codigo original del curso que se esta editando
             * y el lugar donde se guarda el archivo para persistir los datos  
             */
            List<RequisitosAcademicos> listaCursos = ListaRequisitosActuales(file);
            RequisitosAcademicos? requisitoEncontrado = listaCursos.FirstOrDefault(u => u.Id == id);
            if(requisitoEncontrado != null)
            {
                requisitoEncontrado.IdCursosAprobadosJson = requisito.IdCursosAprobadosJson;
                requisitoEncontrado.PromedioMinimo = requisito.PromedioMinimo;
                requisitoEncontrado.CantidadMinimaCreditos = requisito.CantidadMinimaCreditos;
                CRUD.WriteStreamJSON(file, listaCursos);
            }
            

            
        }
    }
}
