
using System;
using System.Windows.Forms;
using System.Data.SQLite;   // <-- Importante: requiere System.Data.SQLite.Core

namespace Interfaz
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Ruta del archivo users.db
            string dbFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.db");

            // Crear la BD si no existe
            CreateDatabaseIfNeeded(dbFile);

            // Lanzar el login
            InicioSesionRegistro loginForm = new InicioSesionRegistro();
            Application.Run(loginForm);
        }

        // ------------------------------------------------------
        // CREA users.db SI NO EXISTE + CREA TABLA "users"
        // ------------------------------------------------------
        public static void CreateDatabaseIfNeeded(string dbFile)
        {
            if (!File.Exists(dbFile))
            {
                // Crear archivo .db
                SQLiteConnection.CreateFile(dbFile);

                using (SQLiteConnection cnx = new SQLiteConnection("Data Source=" + dbFile))
                {
                    cnx.Open();
                    string sql = @"
                        CREATE TABLE users (
                            username TEXT PRIMARY KEY,
                            password TEXT
                        );
                    ";

                    SQLiteCommand cmd = new SQLiteCommand(sql, cnx);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}