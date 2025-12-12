using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class Companies
    {
        //Atributos

        string name;
        string telephone;
        string email;


        //Constructor
        public Companies(string name, string telephone, string email)
        {
            this.name = name;
            this.telephone = telephone;
            this.email = email;
        }


        // Getters / Métodos
        public string GetName()
        { return this.name; }
        public string GetTel()
        { return this.telephone; }
        public string GetEmail()
        { return this.email; }
    }
}