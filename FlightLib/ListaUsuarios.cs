using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class ListaUsuarios
    {
        public BaseDeDatos db;  // Guardamos referencia al Database


        // Constructor que recibe la instancia de Database
        public ListaUsuarios(BaseDeDatos database)
        {
            db = database;
        }


        // Comprueba si un nombre de usuario ya existe en la base de datos
        public bool UsernameExists(string username)
        {
            string sql = $"SELECT 1 FROM usuarios WHERE usuario='{Escape(username)}' LIMIT 1;";
            DataTable dt = db.Select(sql);
            return dt.Rows.Count > 0;
        }


        // Añade un nuevo usuario a la base de datos
        public void AddUser(Usuarios u)
        {
            string sql = $"INSERT INTO usuarios (usuario, contraseña) VALUES ('{Escape(u.GetUsername())}', '{Escape(u.GetPassword())}');";
            db.Execute(sql);
        }

        public bool Authenticate(string username, string password) // Verifica las credenciales del usuario
        {
            string sql = $"SELECT 1 FROM usuarios WHERE usuario='{Escape(username)}' AND contraseña='{Escape(password)}' LIMIT 1;";
            DataTable dt = db.Select(sql);
            return dt.Rows.Count > 0;
        }

        // Escapa caracteres especiales para evitar inyecciones SQL
        private string Escape(string s)
        {
            string resultado = s.Replace("'", "''");
            return resultado;
        }
    }
}
