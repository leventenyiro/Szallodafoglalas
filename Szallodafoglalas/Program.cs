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
                form = new Admin();
            else if (mode == "user")
                form = new User();

            if (form == null)
                MessageBox.Show("Nincs mód meghatározva a configuration.xml fájlban!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Application.Run(form);

            //Scaffold-DbContext "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\temp\hotel.mdf; Integrated Security=True; Connect Timeout=30" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Model -Context Hotel



//Scaffold-DbContext "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Temp\hotel.mdf;Integrated Security=True;Connect Timeout=30" Microsoft.EntityFrameworkCore.SqlServer -ContextDir AutoDir -Context Hotel

        }
    }
}