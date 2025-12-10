using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class CompaniesList
    {
        public BaseDeDatos db;  // Guardamos referencia al Database


        // Constructor que recibe la instancia de Database
        public CompaniesList(BaseDeDatos database)
        {
            db = database;
        }

        // Comprueba si un nombre de empresa  ya existe en la base de datos
        public bool nameExsits(string name)
        {
            string sql = $"SELECT 1 FROM companies WHERE nom='{Escape(name)}' LIMIT 1;";
            DataTable dt = db.Select(sql);
            return dt.Rows.Count > 0;
        }


        // Añade una nueva empresa a la base de datos
        public void AddCompany(Companies c)
        {
            string sql = $"INSERT INTO companies (nom, telf ,correu) VALUES ('{Escape(c.GetName())}', '{Escape(Convert.ToString(c.GetTel()))}','{Escape(c.GetEmail())}');";
            db.Execute(sql);
        }

        public bool Authenticate(string name, int telephone, string email) // Verifica las credenciales de la empresa
        {
            string sql = $"SELECT 1 FROM companies WHERE nom='{Escape(name)}' AND telf='{Escape(Convert.ToString(telephone))}' AND correu='{Escape(email)}' LIMIT 1;";
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
