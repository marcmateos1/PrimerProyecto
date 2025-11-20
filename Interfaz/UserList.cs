using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public class UserList
    {
        List<User> list = new List<User>();
        string filePath;

        public UserList(string storageFile)
        {
            filePath = storageFile;
            LoadFromFile();
        }

        public void AddUser(User u)
        {
            list.Add(u);
        }

        public int Count()
        {
            return list.Count;
        }

        public User Get(int i)
        {
            return list[i];
        }

        public bool UsernameExists(string username)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetUsername() == username) return true;
            }
            return false;
        }

        public bool Authenticate(string username, string password)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetUsername() == username && list[i].GetPassword() == password)
                    return true;
            }
            return false;
        }

        public void SaveToFile()
        {
            try
            {
                StreamWriter w = new StreamWriter(filePath, false);
                for (int i = 0; i < list.Count; i++)
                {
                    //sername password
                    w.WriteLine(list[i].GetUsername() + " " + list[i].GetPassword());
                }
                w.Close();
            }
            catch (Exception)
            {
            }
        }

        public void LoadFromFile()
        {
            list.Clear();
            try
            {
                if (!File.Exists(filePath))
                {
                    // Para crear fichero vacío
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Close();
                    return;
                }

                StreamReader r = new StreamReader(filePath);
                string line = r.ReadLine();
                while (line != null)
                {
                    line = line.Trim();
                    if (line.Length > 0)
                    {
                        string[] parts = line.Split(' ');
                        if (parts.Length >= 2)
                        {
                            string user = parts[0];
                            string pass = parts[1];
                            User u = new User(user, pass);
                            list.Add(u);
                        }
                    }
                    line = r.ReadLine();
                }
                r.Close();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
