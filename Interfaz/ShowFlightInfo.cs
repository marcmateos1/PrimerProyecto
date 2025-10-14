using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightLib;

namespace Interfaz
{
    public partial class ShowFlightInfo : Form
    {
        FlightPlan myFlight;
        public ShowFlightInfo()
        {
            InitializeComponent();
        }

        public void SetFlightPlan(FlightPlan f)
        {
            this.myFlight = f;
        }

        public void ShowFlightInfo_Load(object  sender, EventArgs e)
        {
            Xbox.Text = Convert.ToString(myFlight.GetCurrentPosition().GetX());
            Ybox.Text = Convert.ToString(myFlight.GetCurrentPosition().GetX());
            Velocitybox.Text = Convert.ToString(myFlight.GetVelocidad());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
