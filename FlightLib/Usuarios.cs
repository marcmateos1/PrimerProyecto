using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class Usuarios
    {
        //Atributos

        string username;
        string password;


        //Constructor
        public Usuarios(string username, string password)
        {
            this.username = username;
            this.password = password;
        }


        // Getters / Métodos
        public string GetUsername()
        { return this.username; }
        public string GetPassword()
        { return this.password; }
    }
}
