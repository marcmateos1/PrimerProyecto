using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;









namespace Interfaz
{
    public class UserList
    {
        private SQLiteConnection cnx;

        // Constructor → abre la BD
        public UserList(string dbFile)
        {
            string dataSource = "Data Source=" + dbFile;
            cnx = new SQLiteConnection(dataSource);
            cnx.Open();
        }

        // Comprueba si existe usuario
        public bool UsernameExists(string username)
        {
            string sql = $"SELECT 1 FROM users WHERE username='{Escape(username)}' LIMIT 1;";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt.Rows.Count > 0;
        }

        // Añadir usuario
        public void AddUser(User u)
        {
            string sql = $"INSERT INTO users (username, password) VALUES ('{Escape(u.GetUsername())}', '{Escape(u.GetPassword())}');";
            SQLiteCommand cmd = new SQLiteCommand(sql, cnx);
            cmd.ExecuteNonQuery();
        }

        // Validar login
        public bool Authenticate(string username, string password)
        {
            string sql = $"SELECT 1 FROM users WHERE username='{Escape(username)}' AND password='{Escape(password)}' LIMIT 1;";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt.Rows.Count > 0;
        }

        // Evita errores con comillas
        private string Escape(string s) => s.Replace("'", "''");
    }
}
