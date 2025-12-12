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

        // Comprueba si un nombre ya existe
        private bool NameExists(string name)
        {
            string sql = $"SELECT 1 FROM companies WHERE nom='{Escape(name)}' LIMIT 1;";
            DataTable dt = db.Select(sql);
            return dt.Rows.Count > 0;
        }

        // Comprueba si un teléfono ya existe
        private bool TelExists(string tel)
        {
            string sql = $"SELECT 1 FROM companies WHERE telf='{Escape(tel)}' LIMIT 1;";
            DataTable dt = db.Select(sql);
            return dt.Rows.Count > 0;
        }

        // Comprueba si un correo ya existe
        private bool EmailExists(string email)
        {
            string sql = $"SELECT 1 FROM companies WHERE correu='{Escape(email)}' LIMIT 1;";
            DataTable dt = db.Select(sql);
            return dt.Rows.Count > 0;
        }

        // Añade una nueva empresa a la base de datos
        public void AddCompany(Companies c)
        {
            if (NameExists(c.GetName()))
                throw new Exception("El nombre de la empresa ya existe.");

            if (TelExists(c.GetTel()))
                throw new Exception("El teléfono de la empresa ya existe.");

            if (EmailExists(c.GetEmail()))
                throw new Exception("El correo de la empresa ya existe.");

            string sql = $"INSERT INTO companies (nom, telf, correu) VALUES ('{Escape(c.GetName())}', '{Escape(c.GetTel().ToString())}', '{Escape(c.GetEmail())}');";
            db.Execute(sql);
        }


        // Devuelve una empresa a partir de su nombre
        public Companies GetCompanyByName(string name)
        {
            string sql = $"SELECT nom, telf, correu FROM companies WHERE nom='{Escape(name)}' LIMIT 1;";
            DataTable dt = db.Select(sql);

            if (dt.Rows.Count == 0)
                return null; // No existe la empresa

            string nom = dt.Rows[0]["nom"].ToString();
            string telf = dt.Rows[0]["telf"].ToString();
            string mail = dt.Rows[0]["correu"].ToString();

            return new Companies(nom, telf, mail);
        }


        public bool RemoveCompany(Companies c)
        {
            string sql = $"DELETE FROM Companies WHERE Name = '{c.GetName()}' AND Tel = '{c.GetTel()}' AND Email = '{c.GetEmail()}'";
            int filas = db.Execute(sql);
            return filas > 0;
        }


        // Escapa caracteres especiales para evitar inyecciones SQL
        private string Escape(string s)
        {
            return s.Replace("'", "''");
        }
    }
}
