using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class UserD
    {
        string filename;

        // Constructor que usa users.txt en la carpeta de la aplicación
        public UserD()
        {
            this.filename = Path.Combine(Application.StartupPath, "users.txt");
            if (!File.Exists(this.filename))
            {
                try
                {
                    File.Create(this.filename).Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creando fichero de usuarios: " + ex.Message);
                }
            }
        }

        // Constructor que permite pasar un nombre de fichero
        public UserD(string filename)
        {
            this.filename = filename;
            if (!File.Exists(this.filename))
            {
                try
                {
                    File.Create(this.filename).Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creando fichero de usuarios: " + ex.Message);
                }
            }
        }

        // Registra un usuario
        public bool RegisterUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            try
            {
                string[] lineas = File.ReadAllLines(this.filename);
                for (int i = 0; i < lineas.Length; i++)
                {
                    string linea = lineas[i].Trim();
                    if (linea.Length == 0) continue;
                    string[] partes = linea.Split(' ');
                    if (partes.Length >= 1 && partes[0] == username)
                        return false; // ya existe
                }

                using (StreamWriter sw = new StreamWriter(this.filename, true))
                {
                    sw.WriteLine(username + " " + password);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Authenticate(string username, string password)
        {
            try
            {
                string[] lineas = File.ReadAllLines(this.filename);
                for (int i = 0; i < lineas.Length; i++)
                {
                    string linea = lineas[i].Trim();
                    if (linea.Length == 0) continue;
                    string[] partes = linea.Split(' ');
                    if (partes.Length >= 2)
                    {
                        string u = partes[0];
                        string p = partes[1];
                        if (u == username && p == password)
                            return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
