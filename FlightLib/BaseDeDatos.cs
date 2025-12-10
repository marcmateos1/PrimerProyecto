using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Collections.Generic;

namespace FlightLib
{
    public class BaseDeDatos
    {
        //Atributo privado para la conexión SQLitesdgsdgsgsdfdsgs
        private  SqliteConnection cnx;
        // Constructor que recibe la ruta del archivo. Cuando se crea un objeto Database, le pasa la ruta del archivo de base de datos (dbFile).
        public BaseDeDatos(string dbFile)
        {
            if (!File.Exists(dbFile))
                throw new FileNotFoundException("No se encontró la base de datos en: " + dbFile);  //Si no encuentra el archivo, pues tenemos una excepción

            string dataSource = "Data Source=" + dbFile;
            cnx = new SqliteConnection(dataSource);
            cnx.Open();
        }

        // Método para ejecutar consultas SELECT y devolver un DataTable
        public DataTable Select(string sql)
        {
            DataTable dt = new DataTable();
            //Metodo de usar el select para Microsoft.Data.Sqlite
            using (var cmd = new SqliteCommand(sql, cnx))
            using (var reader = cmd.ExecuteReader())
            {
                dt.Load(reader);
            }
            return dt;
        }


        // Método para ejecutar comandos INSERT, UPDATE, DELETE
        public int Execute(string sql)
        {
            using (var cmd = new SqliteCommand(sql, cnx))
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
