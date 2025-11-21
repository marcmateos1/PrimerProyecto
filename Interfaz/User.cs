using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public class User
    {

        //Atributos

        string username;
        string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string GetUsername() 
            { return this.username; }
        public string GetPassword() 
            { return this.password; }
    }
}
