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
        private SQLiteConnection cnx;

        public void Open(string file)
        {
            string dataSource = "Data Source=" + file;
            cnx = new SQLiteConnection(dataSource);
            cnx.Open();
        }

        public void Close()
        {
            if (cnx != null)
            {
                cnx.Close();
                cnx.Dispose();
                cnx = null;
            }
        }

        public DataTable Select(string sql)
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(dt);
            return dt;
        }

        public int Execute(string sql)
        {
            using (var cmd = new SQLiteCommand(sql, cnx))
            {
                return cmd.ExecuteNonQuery();
            }
        }
    }
}