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
        
        //Atributos
        Interfaz.EspacioAereo espacioAereo;
        FlightPlanList list;
        CompaniesList cList;
        Companies c;
        int posicion;
        BaseDeDatos db;


        //Constructor
        public Informacion(Interfaz.EspacioAereo espacioAereo, FlightPlanList list, int posicion, BaseDeDatos db)
        {
            //iniciar el forms i inicializar las clases necesarias
            InitializeComponent();
            this.espacioAereo = espacioAereo;
            this.list = list;
            this.posicion = posicion;
            this.db = db;
        }


        private void Informacion_Load_1(object sender, EventArgs e)
        {
            FlightPlan plan = list.GetFlightPlan(posicion);
            // Rellenar los labels con la información del flightplan
            label1.Text = $"Id: {plan.GetId()}";
            velocidadBox.Text = Convert.ToString(plan.GetVelocidad());
            label3.Text = $"X actual: {plan.GetCurrentPosition().GetX():F2}";
            label4.Text = $"X final: {plan.GetFinalPosition().GetX():F2}";
            label5.Text = $"Y actual: {plan.GetCurrentPosition().GetY():F2}";
            label6.Text = $"Y final: {plan.GetFinalPosition().GetY():F2}";
            label7.Text = $"X inicial: {plan.GetInitialPosition().GetX():F2}";
            label8.Text = $"Y inicial: {plan.GetInitialPosition().GetY():F2}";
            if (c != null)
            {
                nom.Text = $"Nombre: {c.GetName()}";
                telf.Text = $"Teléfono: {c.GetTel()}";
                mail.Text = $"eMail: {c.GetEmail()}";
            }
            else
            {
                nom.Text = "Nombre: NO ENCONTRADO";
                telf.Text = "Teléfono: NO ENCONTRADO";
                mail.Text = "eMail: NO ENCONTRADO";
            }


        }


        // Volver a principal
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            espacioAereo.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Actualizar la velocidad dentro del forms
            try
            { 
                double speed = Convert.ToDouble(velocidadBox.Text);

                if (speed >= 0)
                {
                    list.GetFlightPlan(posicion).SetVelocidad(speed);
                    MessageBox.Show("Velocidad actualizada");
                }
            else
            MessageBox.Show("La velocidad debe ser un valor positivo");
            }

            catch (FormatException)
            {
                MessageBox.Show("Formato de velocidad no válido");
            }
        }


        public FlightPlanList MyList() //retorna la lista
        {
            return list;
        }
    }
}
