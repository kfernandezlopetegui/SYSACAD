using Actualizar;
using Entidades;
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
        List<Curso> listaCursos = ActualizarCurso.ListaCursosActuales("cursosRegistrados.json");
        List<RequisitosAcademicos> listaRequisitos = ActualizarRequisitos.ListaRequisitosActuales("requisitosRegistrados.json");


        public GestionarRequisitosAcademicos()
        {
            InitializeComponent();
            dataGridViewCursos.DataSource = listaCursos;
            List<CursoConRequisitos> cursosConRequisitos = ObtenerCursosConRequisitos(listaCursos, listaRequisitos);
            dataGridViewCursos.DataSource = cursosConRequisitos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            Menu.MostrarMenu(menuAdministrador, this, 1);
        }

        private static List<CursoConRequisitos> ObtenerCursosConRequisitos(List<Curso> listaCursos, List<RequisitosAcademicos> listaRequisitos)
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
                                          NombreCursosCorrelativos = ActualizarCurso.ObtenerNombreCursoPorCodigo(requisito.IdCursosAprobados, "cursosRegistrados.json")
                                      };

            return cursosConRequisitos.ToList();
        }
    }
}
