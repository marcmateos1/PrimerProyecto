using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;
using System;
using System.IO;
using System.Windows.Forms;

namespace Interfaz
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Ruta relativa desde el ejecutable hasta SQLITEbd\basedatos.db
            string dbFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\SQLITEbd\basedatos.db");
            dbFile = Path.GetFullPath(dbFile); // Normalizmos la ruta

            // Comprobar que la base de datos existe
            if (!File.Exists(dbFile))
                throw new FileNotFoundException("No se encontró la base de datos en: " + dbFile);

            // Lanzar el login, pasando la ruta al constructor
            InicioSesionRegistro loginForm = new InicioSesionRegistro(dbFile);
            Application.Run(loginForm);
        }
    }
}