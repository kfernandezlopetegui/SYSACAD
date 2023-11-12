using Actualizar;
using Entidades;
using LecturaEscritura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_SYSACAD
{
    public partial class GestionarRequisitosAcademicos : Form
    {
        List<Curso> listaCursos = ActualizarCurso.ListaCursosActualesBD();
        List<RequisitosAcademicos> listaRequisitos = ActualizarRequisitos.ListaRequisitosActuales();
        List<CursoConRequisitos> cursosConRequisitos;


        public GestionarRequisitosAcademicos()
        {
            InitializeComponent();
            dataGridViewCursos.DataSource = listaCursos;
            cursosConRequisitos = ObtenerCursosConRequisitos(listaCursos, listaRequisitos);
            dataGridViewCursos.DataSource = cursosConRequisitos;
            dataGridViewCursos.Columns["IdCursosCorrelativos"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            Menu.MostrarMenu(menuAdministrador, this, 1);
        }

        public static List<CursoConRequisitos> ObtenerCursosConRequisitos(List<Curso> listaCursos, List<RequisitosAcademicos> listaRequisitos)
        {
            // Realiza la operación de combinación entre las listas de cursos y requisitos académicos
            var cursosConRequisitos = from curso in listaCursos
                                      join requisito in listaRequisitos
                                      on curso.IdRequisitos equals requisito.Id
                                      select new CursoConRequisitos
                                      {
                                          NombreCurso = curso.Nombre,
                                          CodigoCurso = curso.Codigo,
                                          CantidadMinimaCreditos = requisito.CantidadMinimaCreditos,
                                          PromedioMinimo = requisito.PromedioMinimo,
                                          NombreCursosCorrelativos = ActualizarCurso.ObtenerNombreCursoPorCodigo(CRUD.ConvertirJsonALista(requisito.IdCursosAprobadosJson)),
                                          IdCursosCorrelativos = requisito.IdCursosAprobadosJson
                                      };

            return cursosConRequisitos.ToList();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarRequisitos editarRequisitos = new EditarRequisitos(cursosConRequisitos);
            Menu.MostrarMenu(editarRequisitos, this, 1);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarRequisito eliminarRequisito = new EliminarRequisito();
            Menu.MostrarMenu(eliminarRequisito, this, 1);
        }
    }
}
