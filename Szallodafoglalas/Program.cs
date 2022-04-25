using System.Configuration;

namespace Szallodafoglalas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var mode = ConfigurationManager.AppSettings.Get("Mode");
            Form? form = null;
            if (mode == "Admin")
                form = new AdminForm();
            else if (mode == "User")
                form = new UserForm();

            if (form == null)
                MessageBox.Show("Nincs vagy helytelen mód (Admin vagy User) az App.config fájlban!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Application.Run(form);
        }
    }
}