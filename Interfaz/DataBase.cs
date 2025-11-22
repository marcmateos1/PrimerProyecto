using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public class Database
    {
        // Atributo privado para la conexión SQLite
        private SQLiteConnection cnx;

        // Constructor que recibe la ruta del archivo. Cuando se crea un objeto Database, le pasa la ruta del archivo de base de datos (dbFile).
        public Database(string dbFile)
        {
            if (!File.Exists(dbFile))
                throw new FileNotFoundException("No se encontró la base de datos en: " + dbFile);  //Si no encuentra el archivo, pues tenemos una excepción

            string dataSource = "Data Source=" + dbFile;
            cnx = new SQLiteConnection(dataSource);
            cnx.Open();
        }

        // Método para ejecutar consultas SELECT y devolver un DataTable
        public DataTable Select(string sql)
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(dt);
            return dt;
        }


        // Método para ejecutar comandos INSERT, UPDATE, DELETE
        public int Execute(string sql)
        {
            using (var cmd = new SQLiteCommand(sql, cnx))
            {
                return cmd.ExecuteNonQuery();
            }
        }





        //MÉTODOS QUE NO SON NECESARIOS (No los utilizamos manualmente) PERO PUEDEN SER ÚTILES:


        // Método para cerrar la conexión (aunque se cierra automáticamente al finalizar el programa, por lo que en este caso es muy inútil)
        public void Close()
        {
            if (cnx != null)
            {
                cnx.Close();
                cnx.Dispose();
                cnx = null;
            }
        }

    }
}