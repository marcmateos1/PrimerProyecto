using FlightLib;
using System;
using System.Collections;
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

    public partial class GridForAirspace : Form
    {
        FlightPlanList miLista;

        public GridForAirspace()
        {
            InitializeComponent();
        }

        public void SetData(FlightLib.FlightPlanList lista)
        {
            this.miLista = lista;
        }
        private void GridForAirspace_Load(object sender, EventArgs e)
        {

        }

        public void SetFlightPlans()
        {
            // Asegúrate de que el DataGridView tenga las columnas correctas
            Taula.Columns.Clear(); // Limpiar si ya existen columnas
            Taula.Columns.Add("ID", "ID");
            Taula.Columns.Add("Velocidad", "Velocidad");
            Taula.Columns.Add("PosicionInicial", "Posición Inicial");
            Taula.Columns.Add("PosicionFinal", "Posición Final");
            Taula.Columns.Add("PosicionActual", "Posición Actual");

            // Añadir las filas con la información de los FlightPlans
            for (int i = 0; i < 2; i++)
            {


                FlightPlan plan = this.miLista.GetFlightPlan(i);

                string id = plan.GetId();
                double velocidad = plan.GetVelocidad();
                string posicionInicial = $"({plan.GetInitialPosition().GetX()}  ,  {plan.GetInitialPosition().GetY()})";
                string posicionFinal = $"({plan.GetFinalPosition().GetX()}  ,  {plan.GetFinalPosition().GetY()})";
                string posicionActual = $"({Math.Round(plan.GetCurrentPosition().GetX(),2)} , {Math.Round(plan.GetCurrentPosition().GetY(), 2)})";

                // Añadir la fila con los datos
                Taula.Rows.Add(id, velocidad, posicionInicial, posicionFinal, posicionActual);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Position p1= miLista.GetFlightPlan(0).GetCurrentPosition();
            Position p2= miLista.GetFlightPlan(1).GetCurrentPosition();

            double distancia = p1.Distancia(p2);
            ShowDistancePlans nuevoformulario = new ShowDistancePlans();
            nuevoformulario.SetData(distancia);
            nuevoformulario.ShowDistance();
            nuevoformulario.Show();
        }
    }
}
