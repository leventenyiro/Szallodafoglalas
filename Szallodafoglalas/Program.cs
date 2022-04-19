using System.Xml;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            XmlDocument doc = new XmlDocument();
            doc.Load("configuration.xml");
            var node = doc.SelectSingleNode("mode");
            string mode = node != null ? node.InnerText : "";

            Form? form = null;
            if (mode == "admin")
                form = new AdminForm();
            else if (mode == "user")
                form = new UserForm();

            if (form == null)
                MessageBox.Show("Nincs mód meghatározva a configuration.xml fájlban!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Application.Run(form);
        }
    }
}