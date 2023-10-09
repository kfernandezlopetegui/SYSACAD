using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_SYSACAD
{
    internal class Menu
    {
        public static void MostrarMenu(Form menuAMostrar, Form menuAOcultar)
        {
            // Oculta el menú anterior (si existe)
            if (menuAOcultar != null)
            {
                menuAOcultar.Hide();
            }

            // Muestra el nuevo menú
            menuAMostrar.Show();
        }
        public static void MostrarMenu(Form menuAMostrar, Form menuAOcultar,int numero)
        {
            // Oculta el menú anterior (si existe)
            if (menuAOcultar != null && numero ==1)
            {
                menuAOcultar.Close();
            }

            // Muestra el nuevo menú
            menuAMostrar.Show();
        }
    }
}
