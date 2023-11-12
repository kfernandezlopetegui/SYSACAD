﻿using Actualizar;
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
    public partial class EliminarCurso : Form
    {
        private List<Curso> listaCursos = ActualizarCurso.ListaCursosActualesBD();
        public EliminarCurso()
        {
            InitializeComponent();
            dataGridViewCursos.DataSource = listaCursos;
            dataGridViewCursos.Columns["CupoActual"].Visible = false;
            dataGridViewCursos.Columns["Id"].Visible = false;
            dataGridViewCursos.Columns["IdRequisitos"].Visible = false;
        }

        private void dataGridViewCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Curso cursoSeleccionado = (Curso)dataGridViewCursos.Rows[e.RowIndex].DataBoundItem;



            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar este curso?", "Confirmar eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int idRequisitoEliminar = cursoSeleccionado.IdRequisitos;
                ActualizarCurso.BorrarCursoPorCodigoBD(cursoSeleccionado.Codigo);
                ActualizarRequisitos.BorrarRequisitoPorId(idRequisitoEliminar);

                DialogResult resultadoBorrado = MessageBox.Show("¡Eliminacion exitosa! El curso se ha borrado correctamente.",
                                           "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultadoBorrado == DialogResult.OK)
                {
                    ListaDeCursos listaCurso = new ListaDeCursos();
                    Menu.MostrarMenu(listaCurso, this, 1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaDeCursos listaCurso = new ListaDeCursos();
            Menu.MostrarMenu(listaCurso, this, 1);
        }
    }
}
