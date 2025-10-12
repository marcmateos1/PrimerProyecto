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
    public partial class Informacion : Form
    {
        Interfaz.Principal principal;
        FlightPlan plan;
        public Informacion(Interfaz.Principal principal, FlightPlan plan)
        {
            InitializeComponent();
            this.principal = principal;
            this.plan = plan;
        }
        private void Informacion_Load_1(object sender, EventArgs e)
        {
            label1.Text = $"Id: {plan.GetId()}";
            label2.Text = $"Velocidad: {plan.GetVelocidad()}";
            label3.Text = $"X inicial: {plan.GetCurrentPosition().GetX()}";
            label4.Text = $"X final: {plan.GetFinalPosition().GetX()}";
            label5.Text = $"Y inicial: {plan.GetCurrentPosition().GetY()}";
            label6.Text = $"Y final: {plan.GetFinalPosition().GetY()}";

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            principal.Show();
        }


    }
}
