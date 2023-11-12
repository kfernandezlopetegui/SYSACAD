using DB;
using Entidades;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Data.SqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Utilities;
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

        private void buttonCrear_Click(object sender, EventArgs e)
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
            Curso nuevoCurso = new Curso("PRUEBA", "12344", "DESCRIPCION", 2, "TUP", 20);
            string respuesta = DataBase.InsertarRegistro<Curso>(nuevoCurso);
            MessageBox.Show(respuesta);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            string dni = textBoxDni.Text;
            string resultado = CRUDB.EliminarPorCondicion<Alumno>("Alumno", "Dni", dni);
            MessageBox.Show(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombreActualizar.Text;
            string apellido = textBoxApellidoActualizar.Text;

            Alumno alumno2 = new Alumno(nombre, apellido, "Femenino", "karen", Hash.GetHash("1234"), true,
                false, "estudiante", "1999,08,28", "Mango", 1112, 94298163, "nandubay 123", "1173610818");
            string resultado = CRUDB.ActualizarPorIdentificador("Alumno", "Dni", "94298161", alumno2);
            MessageBox.Show(resultado);
        }


        private void CargarDatos()
        {
            // Limpia el DataTable antes de volver a cargar datos
            tablaDatos.Clear();

            // Llena el DataTable con los datos de la base de datos
            adaptador.Fill(tablaDatos);

            // Vincula el DataTable al DataGridView
            dataGridView1.DataSource = CRUDB.ObtenerTodos<Curso>("Curso");
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
    }

}
