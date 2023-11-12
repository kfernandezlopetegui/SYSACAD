using Actualizar;
using Entidades;
using Validaciones;

namespace New_SYSACAD
{
    public partial class Form1 : Form
    {
        public ValidarUsuario validarUsuario;
        public Form1()
        {
            InitializeComponent();
            validarUsuario = new ValidarUsuario();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = this.textBox1.Text;
            string password = this.textBox2.Text;
            int resultadoAutenticacion = validarUsuario.VerificarUsuario(usuario, password);

            switch (resultadoAutenticacion)
            {
                case 1:
                    MenuAdministrador menuAdministrador = new MenuAdministrador();
                    Menu.MostrarMenu(menuAdministrador, this);
                    break;
                case 0:
                    Alumno alumno = validarUsuario.VerificarSiExisteAlumnoBD(usuario);
                    MenuEstudiante menuEstudiante = new MenuEstudiante(alumno);
                    Menu.MostrarMenu(menuEstudiante, this);
                    break;
                default:
                    MessageBox.Show("Error. Usuario o contraseña incorrectos");
                    break;
            }
        }






        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.UseSystemPasswordChar = true;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }



        private void buttonHarcodearAdmin_Click(object sender, EventArgs e)
        {
            textBox1.Text = "admin";
            textBox1.ForeColor = Color.Black;
            textBox2.Text = "admin";
            textBox2.ForeColor = Color.Black;
            textBox2.UseSystemPasswordChar = true;
        }

        private void buttonHarcodearAlumno_Click(object sender, EventArgs e)
        {
            textBox1.Text = "karen";
            textBox1.ForeColor = Color.Black;
            textBox2.Text = "1234";
            textBox2.ForeColor = Color.Black;
            textBox2.UseSystemPasswordChar = true;

        }

        private void buttonPruebas_Click(object sender, EventArgs e)
        {
            PruebaSQL prueba = new PruebaSQL();
            Menu.MostrarMenu(prueba, this);
        }

        private void buttonAgregarAprobado_Click(object sender, EventArgs e)
        {
            ActualizarUsuarios.AgregarCursosAprobados("232323", 94298161);
        }
    }
}