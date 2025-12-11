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
    public partial class ShowDistancePlans : Form
    {

        //Atributs
        FlightPlanList miLista;
        FlightPlan plan;

        //Constructor
        public ShowDistancePlans()
        {
            InitializeComponent();
        }


        //Método para establecer los datos de la clase
        public void SetData(FlightPlanList miLista, FlightPlan plan)
        {
            this.miLista = miLista;
            this.plan = plan;
        }


        public void ShowDistancePlans_Load()
        {
            //Crear el estilo y medida del grid
            Taula2.RowCount = miLista.NumElementosLista();
            Taula2.ColumnCount = 2;
            Taula2.ColumnHeadersVisible = false;
            Taula2.RowHeadersVisible = false;
            Taula2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Taula2[0, 0].Value = $"Con {plan.GetId()}";
            Taula2[1, 0].Value = ("Distancia");

            int j = 0;
            for (int i = 0; i < miLista.NumElementosLista(); i++)
            {
                FlightPlan otroplan = miLista.GetFlightPlan(i);
                if (otroplan != plan)//Inidicar los valores de cada celda del grid (al atributo que corresponde)
                {
                    double distancia = plan.DistanceTo(otroplan);
                    Taula2[0, j + 1].Value = (otroplan.GetId());
                    Taula2[1, j + 1].Value = Math.Round(distancia, 2);
                    j = j + 1;
                }
            }
        }

        private void Taula2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
