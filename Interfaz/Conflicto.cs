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
        string id1;
        string id2;
        FlightPlanList miLista;
        public Conflicto(string id1, string id2)
        {
            this.id1 = id1;
            this.id2 = id2;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void Conflicto_Load_1(object sender, EventArgs e)
        {
            label2.Text = "Conflicto entre " + id1 + "y " + id2 + ".";
        }
    }
}
