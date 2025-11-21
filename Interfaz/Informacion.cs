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
        FlightPlanList list;
        int posicion;
        public Informacion(Interfaz.EspacioAereo espacioAereo, FlightPlanList list, int posicion)
        {
            //iniciar el forms i inicialitzar les classes necessaries
            InitializeComponent();
            this.espacioAereo = espacioAereo;
            this.list = list;
            this.posicion = posicion;
        }
        private void Informacion_Load_1(object sender, EventArgs e)
        {
            FlightPlan plan = list.GetFlightPlan(posicion);
            //posar tota la info al forms
            label1.Text = $"Id: {plan.GetId()}";
            velocidadBox.Text = Convert.ToString(plan.GetVelocidad());
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

        private void button1_Click(object sender, EventArgs e)
        {
            //canviar la velocitat dins el forms
            try { 
            double speed = Convert.ToDouble(velocidadBox.Text);
            Console.WriteLine(speed);
            Console.ReadLine();
            list.GetFlightPlan(posicion).SetVelocidad(speed);
            MessageBox.Show("Velocidad actualizada");
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de velocidad no válido");
            }
        }

        public FlightPlanList MyList()
        {
            return list;
        }
    }
}
