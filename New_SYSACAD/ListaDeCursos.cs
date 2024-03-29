﻿using Actualizar;
using Entidades;
using Interfaces;
using LogicaSysacad;
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
    public partial class ListaDeCursos : Form, ITraerLista
    {
        

        public event Action OnListaPedida;

        public ListaDeCursos()
        {
            InitializeComponent();
            var logica = new TraerListaCursoLogica(this);

            OnListaPedida?.Invoke();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarCurso eliminarCurso = new EliminarCurso();
            Menu.MostrarMenu(eliminarCurso, this, 1);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarCurso editarCurso = new EditarCurso();
            Menu.MostrarMenu(editarCurso, this, 1);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            Menu.MostrarMenu(menuAdministrador, this, 1);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarCurso agregarCurso = new AgregarCurso();
            Menu.MostrarMenu(agregarCurso, this, 1);
        }

        public void AsignarLista<T>(List<T> lista)
        {
            dataGridViewCursos.DataSource = lista;
            dataGridViewCursos.Columns["cupoActual"].Visible = false;
            dataGridViewCursos.Columns["Id"].Visible = false;
            dataGridViewCursos.Columns["IdRequisitos"].Visible = false;
        }
    }
}
