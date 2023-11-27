using DB;
using Entidades;
using Google.Protobuf.WellKnownTypes;
using LecturaEscritura;
using Microsoft.Data.SqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Utilities;
using Pagos;
using PDF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_SYSACAD
{
    public partial class PruebaSQL : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataTable tablaDatos;
        public PruebaSQL()
        {
            InitializeComponent();
            string cadenaConexion = @"Server=.;Database=Prueba;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
            conexion = new SqlConnection(cadenaConexion);

            // Inicializa el DataTable
            tablaDatos = new DataTable();

            // Configura el adaptador con la consulta SQL y la conexión
            string consultaSQL = "SELECT * FROM Alumno";
            adaptador = new SqlDataAdapter(consultaSQL, conexion);

            CargarDatos();

        }

        private async void buttonCrear_Click(object sender, EventArgs e)
        {
            // DataBase.CreateTable<Alumno>();
            /*Alumno alumno1 = new Alumno("karen", "fernandez", "Femenino", "karen", Hash.GetHash("1234"), true,
                 false, "estudiante", "1999,08,28", "Mango", 1112, 94298161, "nandubay 123", "1173610818");
            Alumno alumno2 = new Alumno("karen", "fernandez", "Femenino", "karen", Hash.GetHash("1234"), true,
                 false, "estudiante", "1999,08,28", "Mango", 1113, 94298162, "nandubay 123", "1173610818");
            string resultado = DataBase.InsertarRegistro<Alumno>(alumno1);
            MessageBox.Show(resultado);
            resultado = DataBase.InsertarRegistro<Alumno>(alumno2);
            MessageBox.Show(resultado);*/
            /*Alumno alumno = CRUDB.ObtenerPorIdentificador<Alumno>("Alumno", "Dni = @Dni", new { Dni = 94298161 });
            string resultado;
            if (alumno != null)
            {
                resultado = $"ID: {alumno.Dni}, Nombre: {alumno.Nombre}, Carrera: {alumno.Apellido}";
                
            }
            else
            {
                resultado = "Alumno no encontrado.";
            }*/
            /*Curso nuevoCurso = new Curso("PRUEBA", "12344", "DESCRIPCION", 2, "TUP", 20);
            string respuesta = DataBase.InsertarRegistro<Curso>(nuevoCurso);*/

            int legajo = DataBase.ObtenerUltimoLegajoProfesor();
            legajo++;
            string cursosAProbados = CRUD.ConvertirListaAJson(new List<string>());
            Alumno alumno = new Alumno("Prueba", "Asincronico", "indefinido", "asincronico@gmail.com", "hola1234",
                    false, false, "estudiante", "23/11/2000", "asincronico", legajo,
                    93298161, "calle falsa", "123324353", cursosAProbados);
            Profesor profesor2 = new Profesor("Profesor", "2", "indefinido", "profe@gmail.com", "1234", false, false,
                "Profesor", "12/12/2000", "Mango", 1050, 96298162, "calle falsa 1233", "11123249395", "Matematicas");
            //await CRUDB.InsertarRegistroAsync<Profesor>(profesor2);
            CursosAsignados cursoAsignado = new CursosAsignados("090909", profesor2.Dni);



            //string resultado = await CRUDB.InsertarRegistroAsync(cursoAsignado); ;

            string resultado = await CRUDB.CreateTableAsync<Notificacion>();

            MessageBox.Show(resultado);
        }

        private async void buttonBorrar_Click(object sender, EventArgs e)
        {
            string dni = textBoxDni.Text;
            string resultado = await CRUDB.EliminarPorCondicionAsync<Alumno>("Alumno", "Dni", dni);
            MessageBox.Show(resultado);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombreActualizar.Text;
            string apellido = textBoxApellidoActualizar.Text;
            string cursosAProbados = CRUD.ConvertirListaAJson(new List<string>());
            Alumno alumno2 = new Alumno(nombre, apellido, "Femenino", "karen", Hash.GetHash("1234"), true,
                false, "estudiante", "1999,08,28", "Mango", 1112, 94298163, "nandubay 123", "1173610818", cursosAProbados);
            string resultado = await CRUDB.ActualizarPorIdentificadorAsync("Alumno", "Dni", "94298161", alumno2);
            MessageBox.Show(resultado);
        }


        private void CargarDatos()
        {
            // Limpia el DataTable antes de volver a cargar datos
            tablaDatos.Clear();

            // Llena el DataTable con los datos de la base de datos
            adaptador.Fill(tablaDatos);

            dataGridView1.Columns.Clear();

            // Configura las columnas manualmente

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = CRUDB.ObtenerAlumnosInscritos("4802023");

            /* dataGridView1.Columns["Nombre"].HeaderText = "Nombre del Curso";
             dataGridView1.Columns["Id"].Visible = false;
             dataGridView1.Columns["IdRequisitos"].Visible = false;
             dataGridView1.Columns["CupoActual"].Visible = false;
             dataGridView1.Columns["CupoMaximo"].Visible = false;*/

            // Vincula el DataTable al DataGridView
            //dataGridView1.DataSource = CRUDB.ObtenerSolicitudesPorIdCurso("676767");

        }

        private void buttonActualizarTabla_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (CRUDB.EsIdentificadorUnico<Alumno>("Alumno", "Dni", textBoxValidar.Text))
            {
                MessageBox.Show("Podes usarlo tranqui!!");
            }
            else
            {
                MessageBox.Show("Ya existee");
            }
        }

        private void buttonInscripciones_Click(object sender, EventArgs e)
        {
            Periodo periodo = new Periodo("Periodo",dateTimePickerInicio.Value, dateTimePickerFin.Value);
            dataGridViewInscripciones.DataSource = CRUDB.ObtenerInscripcionesEnPeriodo(periodo);
            PDFInscripcionesPorPeriodo.CreatePdf(CRUDB.ObtenerInscripcionesEnPeriodo(periodo),periodo);

        }

       

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            ValidarFechaInicio();
        }

        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            ValidarFechaFin();
        }

        private void dateTimePickerFin_Validating(object sender, CancelEventArgs e)
        {
            ValidarFechaFin();
        }

        private void dateTimePickerInicio_Validating(object sender, CancelEventArgs e)
        {
            ValidarFechaInicio();
        }

        private void ValidarFechaInicio()
        {
            if (dateTimePickerInicio.Value > dateTimePickerFin.Value)
            {
                // La fecha de inicio es posterior a la fecha de fin
                // Mostrar mensaje de error
                MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Establecer la fecha de inicio en el día de hoy
                dateTimePickerInicio.Value = DateTime.Today;
            }
        }

        private void ValidarFechaFin()
        {
            if (dateTimePickerFin.Value < dateTimePickerInicio.Value)
            {
                // La fecha de fin es anterior a la fecha de inicio
                // Mostrar mensaje de error
                MessageBox.Show("La fecha de fin debe ser posterior a la fecha de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Establecer la fecha de fin en el día de hoy
                dateTimePickerFin.Value = DateTime.Today;
            }
        }
    }

}
