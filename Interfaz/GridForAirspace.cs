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
            try
            {
                int j = this.miLista.NumElementosLista();
                Taula.RowCount = j + 1;
                Taula.ColumnCount = 5;
                Taula.ColumnHeadersVisible = false;
                Taula.RowHeadersVisible = false;
                Taula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Taula[0, 0].Value = ("ID");
                Taula[1, 0].Value = ("Velocidad");
                Taula[2, 0].Value = ("PosicionInicial");
                Taula[3, 0].Value = ("PosicionFinal");
                Taula[4, 0].Value = ("PosicionActual");

                for (int i = 0; i < j; i++)
                {
                    FlightPlan plan = this.miLista.GetFlightPlan(i);
                    string id = plan.GetId();
                    double velocidad = plan.GetVelocidad();
                    string posicionInicial = $"({plan.GetInitialPosition().GetX()}  ,  {plan.GetInitialPosition().GetY()})";
                    string posicionFinal = $"({plan.GetFinalPosition().GetX()}  ,  {plan.GetFinalPosition().GetY()})";
                    string posicionActual = $"({Math.Round(plan.GetCurrentPosition().GetX(), 2)} , {Math.Round(plan.GetCurrentPosition().GetY(), 2)})";
                    Taula[0, i + 1].Value = id;
                    Taula[1, i + 1].Value = velocidad;
                    Taula[2, i + 1].Value = posicionInicial;
                    Taula[3, i + 1].Value = posicionFinal;
                    Taula[4, i + 1].Value = posicionActual;
                }
            }
            catch (Exception) { MessageBox.Show("Informació no carregada correctament"); }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Position p1 = miLista.GetFlightPlan(0).GetCurrentPosition();
            Position p2 = miLista.GetFlightPlan(1).GetCurrentPosition();

            double distancia = p1.Distancia(p2);
            ShowDistancePlans nuevoformulario = new ShowDistancePlans();
            nuevoformulario.SetData(distancia);
            nuevoformulario.ShowDistance();
            nuevoformulario.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
