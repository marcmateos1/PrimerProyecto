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
        Interfaz.EspacioAereo espacioAereo;
        FlightPlan plan;
        public Informacion(Interfaz.EspacioAereo espacioAereo, FlightPlan plan)
        {
            InitializeComponent();
            this.espacioAereo = espacioAereo;
            this.plan = plan;
        }
        private void Informacion_Load_1(object sender, EventArgs e)
        {
            label1.Text = $"Id: {plan.GetId()}";
            label2.Text = $"Velocidad: {plan.GetVelocidad():F2}";
            label3.Text = $"X actual: {plan.GetCurrentPosition().GetX():F2}";
            label4.Text = $"X final: {plan.GetFinalPosition().GetX():F2}";
            label5.Text = $"Y actual: {plan.GetCurrentPosition().GetY():F2}";
            label6.Text = $"Y final: {plan.GetFinalPosition().GetY():F2}";
            label7.Text = $"X inicial: {plan.GetInitialPosition().GetX():F2}";
            label8.Text = $"Y inicial: {plan.GetInitialPosition().GetY():F2}";

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            espacioAereo.Show();
        }


    }
}
