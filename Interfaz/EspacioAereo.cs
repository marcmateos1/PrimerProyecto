using FlightLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class EspacioAereo : Form
    {
        Interfaz.Principal principal;
        FlightPlanList miLista;
        int tiempoCiclo;

        //vector de picture boxes para representar los aviones
        PictureBox[] vuelos;

        public EspacioAereo(Interfaz.Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        public void SetData(FlightPlanList f, int c)
        {
            miLista = f;
            tiempoCiclo = c;
        }

        private void EspacioAereo_Load(object sender, EventArgs e)
        {
            vuelos = new PictureBox[miLista.NumElementosLista()];
            for (int i = 0; i < miLista.NumElementosLista(); i++)
            {
                //representar vuelo de la posicion i
                PictureBox p = new PictureBox();
                FlightPlan plan = miLista.GetFlightPlan(i);
                //tamaño del elemento
                p.Width = 10;
                p.Height = 10;
                p.ClientSize = new Size(10, 10);
                //posición del elemento
                //p.Location = new Point(plan.GetCurrentPosition().GetX(), plan.GetFlightPlan(i).GetCurrentPosition().GetY());
                int x = (int)(plan.GetCurrentPosition().GetX() * panel1.Width / 750.0);
                int y = (int)(plan.GetCurrentPosition().GetY() * panel1.Height / 500.0);
                p.Location = new Point(x, y);


                //p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.BackColor = Color.Red;

                vuelos[i] = p;

                panel1.Controls.Add(p);
            }
        }
        private void botonMover_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < miLista.NumElementosLista(); i++)
            {
                FlightPlan plan = miLista.GetFlightPlan(i);
                plan.Mover(tiempoCiclo);
                int x = (int)(plan.GetCurrentPosition().GetX() * panel1.Width / 750.0);
                int y = (int)(plan.GetCurrentPosition().GetY() * panel1.Height / 500.0);
                vuelos[i].Location = new Point(x, y);
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            principal.Show();
        }
    }
}
