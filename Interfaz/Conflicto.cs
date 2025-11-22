using FlightLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Conflicto : Form
    {

        //Atributos
        string id1;
        string id2;
        FlightPlanList miLista;


        //Constructor
        public Conflicto(string id1, string id2)
        {
            //indicar qué vuelos (atributos id de la clase flightplan) se cogen para arreglar el conflicto
            this.id1 = id1;
            this.id2 = id2;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //botón de SI (para resolver el conflicto)
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //botón de NO (dejarlo como está)
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        //Escribe en label4 que hay un conflicto entre id1 i id2
        private void Conflicto_Load_1(object sender, EventArgs e)
        {
            label4.Text = "Conflicto entre " + id1 + "y " + id2 + ".";
        }

        private void label4_Click(object sender, EventArgs e)
        { 
            
        }
    }
}
