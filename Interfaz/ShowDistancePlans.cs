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
    public partial class ShowDistancePlans : Form
    {
        double distance;
        public ShowDistancePlans()
        {
            InitializeComponent();
        }
        public void SetData(double distance)
        {
            this.distance = distance;
        }
        public void ShowDistance()
        {
            label1.Text = "La distancia entre los dos aviones es: " + Math.Round(this.distance, 2) + " unidades.";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
