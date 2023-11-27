namespace New_SYSACAD
{
    using Pagos;
    using System.Windows.Forms;
    using UtilidadesNotificaciones;

    internal static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            NotificacionManager notificacionManager = new NotificacionManager();
            Application.Run(new Form1());
        }



    }

}