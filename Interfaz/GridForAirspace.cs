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
                //crear mides i disseny del datagridview
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
                //posar els valors al datagridview
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
            //nou forms quan es clica dins una cela
            int fila = e.RowIndex;
            if (fila != 0)
            {
                int indice = fila - 1;
                FlightPlan plan = this.miLista.GetFlightPlan(indice);
                ShowDistancePlans nuevoformulario = new ShowDistancePlans();
                nuevoformulario.SetData(miLista, plan);
                nuevoformulario.ShowDistancePlans_Load();
                nuevoformulario.ShowDialog();
                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
