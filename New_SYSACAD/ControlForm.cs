using Entidades;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
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
    public partial class ControlForm : UserControl
    {
        public ControlForm()
        {
            InitializeComponent();
        }
        public static void MostrarError(TextBox textBox, string nombreCampo, string mensaje)
        {
            ///Muestra el mensaje de error cuando esta vacio y hace foco en el textbox 
            MessageBox.Show($"{nombreCampo} {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox.Focus();
            
        }
        

        public static bool ValidarCampoNoVacio(TextBox textBox, string nombreCampo)
        {
            /// Valida que el campo del textbox no este vacio 
            /// Recibe el textbox y el nombre del campo para poder mostrar el mensaje de error
            string valorCampo = textBox.Text.Trim();

            if (string.IsNullOrEmpty(valorCampo))
            {
                MostrarError(textBox, nombreCampo,"no puede estar vacio.");
                return false;
            }

            return true;
        }

        public static bool ValidarCampoNoPorDefecto(TextBox textBox, string nombreCampo, string textoPorDefecto)
        {
            /// Valida que el campo del textbox no sea el mismo que trae por defecto
            string valorCampo = textBox.Text.Trim();

            if (valorCampo == textoPorDefecto)
            {
                MostrarError(textBox, nombreCampo, "no puede estar vacio.");
                return false;
            }

            return true;
        }

        public static void GenerarPDFConImagen(string nombreArchivoPDF, string rutaImagen)
        {
            // Crear un documento PDF
            PdfDocument pdf = new PdfDocument();
            PdfPage page = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Cargar la imagen desde el archivo
            XImage image = XImage.FromFile(rutaImagen);

            // Dibujar la imagen en el documento PDF
            gfx.DrawImage(image, 0, 0);

            // Guardar el documento PDF en el archivo especificado
            pdf.Save(nombreArchivoPDF);
            Console.WriteLine("Informe generado y guardado como PDF.");
        }


        public static bool EsMayorDeEdad(DateTime fechaNacimiento)
        {
            // Calcular la edad
            int edad = CalcularEdad(fechaNacimiento);

            // Verificar si la edad es mayor o igual a 18
            return edad >= 18;
        }

        static int CalcularEdad(DateTime fechaNacimiento)
        {
            // Calcular la edad restando el año de nacimiento al año actual
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            // Ajustar la edad si aún no ha llegado el cumpleaños de este año
            if (DateTime.Now < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }

            return edad;
        }


    }
}
