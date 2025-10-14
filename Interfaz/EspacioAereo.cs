using FlightLib;
using System;
using System.Collections;
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
        float distanciaSeguridad;

        //vector de picture boxes para representar los aviones
        PictureBox[] vuelos;

        public EspacioAereo(Interfaz.Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        public void SetData(FlightPlanList f, int c, float distancia)
        {
            miLista = f;
            tiempoCiclo = c;
            distanciaSeguridad = distancia;
        }

        private void EspacioAereo_Load(object sender, EventArgs e)
        {
            vuelos = new PictureBox[miLista.NumElementosLista()];
            for (int i = 0; i < miLista.NumElementosLista(); i++)
            {
                // Representar vuelo de la posición i
                PictureBox p = new PictureBox();
                FlightPlan plan = miLista.GetFlightPlan(i);

                // Tamaño del elemento
                p.Width = 10;
                p.Height = 10;
                p.ClientSize = new Size(10, 10);

                // Calcular posición escalada
                int x = (int)(plan.GetCurrentPosition().GetX() * panel1.Width / 500.0);
                int y = (int)(plan.GetCurrentPosition().GetY() * panel1.Height / 500.0);

                // Ajustar para centrar el círculo en las coordenadas
                p.Location = new Point(x - p.Width / 2, y - p.Height / 2);


                // Pero si querés que sea un CÍRCULO ROJO:
                Bitmap bmp = new Bitmap(p.Width, p.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.FillEllipse(Brushes.Red, 0, 0, p.Width - 1, p.Height - 1);
                }
                p.Image = bmp;

                // Guardar y agregar al panel
                vuelos[i] = p;
                panel1.Controls.Add(p);

                // Crear el PictureBox del destino
                PictureBox destino = new PictureBox();
                destino.Width = 10;
                destino.Height = 10;
                destino.ClientSize = new Size(10, 10);

                // Calcular posición del destino (escalar igual que el vuelo)
                int xd = (int)(plan.GetFinalPosition().GetX() * panel1.Width / 500.0);
                int yd = (int)(plan.GetFinalPosition().GetY() * panel1.Height / 500.0);

                // Centrar la cruz en el punto destino
                destino.Location = new Point(xd - destino.Width / 2, yd - destino.Height / 2);

                // Dibujar una cruz
                Bitmap bmp2 = new Bitmap(destino.Width, destino.Height);
                using (Graphics g = Graphics.FromImage(bmp2))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    Pen pen = new Pen(Color.Blue, 2); // color y grosor de la cruz
                    g.DrawLine(pen, 0, destino.Height / 2, destino.Width, destino.Height / 2); // línea horizontal
                    g.DrawLine(pen, destino.Width / 2, 0, destino.Width / 2, destino.Height);  // línea vertical
                }
                destino.Image = bmp2;

                // Agregar al panel
                panel1.Controls.Add(destino);

                // Evento de clic
                p.Click += PictureBox_Click;

            }
        }
        private void botonMover_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < miLista.NumElementosLista(); i++)
            {
                // Representar vuelo de la posición i
                PictureBox p = new PictureBox();

                // Tamaño del elemento
                p.Width = 10;
                p.Height = 10;
                p.ClientSize = new Size(10, 10);

                FlightPlan plan = miLista.GetFlightPlan(i);
                plan.Mover(tiempoCiclo);
                int x = (int)(plan.GetCurrentPosition().GetX() * panel1.Width / 500.0);
                int y = (int)((plan.GetCurrentPosition().GetY() * panel1.Height / 500.0));
                vuelos[i].Location = new Point(x - p.Width / 2, y - p.Height / 2);
                panel1.Invalidate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Draw the line
            try
            {
                System.Drawing.Graphics graphics = e.Graphics;
                Pen rutaPen = new Pen(Color.Red);
                Pen zonaPen = new Pen(Color.Blue);
                int radio = (int)(distanciaSeguridad * panel1.Width / 500.0);

                for (int i = 0; i < miLista.NumElementosLista(); i++)
                {
                    graphics.DrawLine(rutaPen, Convert.ToInt32(miLista.GetFlightPlan(i).GetInitialPosition().GetX() * panel1.Width / 500.0), Convert.ToInt32(miLista.GetFlightPlan(i).GetInitialPosition().GetY() * panel1.Height / 500.0), Convert.ToInt32(miLista.GetFlightPlan(i).GetFinalPosition().GetX() * panel1.Width / 500.0), Convert.ToInt32(miLista.GetFlightPlan(i).GetFinalPosition().GetY() * panel1.Height / 500.0));
                    
                    int x = (int)(miLista.GetFlightPlan(i).GetCurrentPosition().GetX() * panel1.Width / 500.0);
                    int y = (int)(miLista.GetFlightPlan(i).GetCurrentPosition().GetY() * panel1.Height / 500.0);
                    graphics.DrawEllipse(zonaPen, x - radio, y - radio, radio * 2, radio * 2);
                }

                rutaPen.Dispose();
                zonaPen.Dispose();
            }
            catch
            {

            }


        }

        private void simularAut_Click(object sender, EventArgs e)
        {
            Reloj.Interval = 100;
            Reloj.Start();
        }

        private void Parar_Click(object sender, EventArgs e)
        {
            Reloj.Stop();
        }



        private void Reloj_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < miLista.NumElementosLista(); i++)
            {
                // Representar vuelo de la posición i
                PictureBox p = new PictureBox();

                // Tamaño del elemento
                p.Width = 10;
                p.Height = 10;
                p.ClientSize = new Size(10, 10);

                FlightPlan plan = miLista.GetFlightPlan(i);
                plan.Mover(tiempoCiclo);
                int x = (int)(plan.GetCurrentPosition().GetX() * panel1.Width / 500.0);
                int y = (int)((plan.GetCurrentPosition().GetY() * panel1.Height / 500.0));
                vuelos[i].Location = new Point(x - p.Width / 2, y - p.Height / 2);
                panel1.Invalidate();
            }
            panel1.Invalidate();

            //Comprobar si hay conflicto
            double distanciaActual = miLista.GetFlightPlan(0).GetCurrentPosition().Distancia(miLista.GetFlightPlan(1).GetCurrentPosition());
            if (miLista.GetFlightPlan(0).Conflicto(distanciaActual, distanciaSeguridad))
            {
                MessageBox.Show("¡Conflicto detectado! La distancia entre los aviones es de " + distanciaActual.ToString("F2") + " unidades.");
                //Reloj.Stop();
            }
        }

        private void ShowInfo_Click(object sender, EventArgs e)
        {
            GridForAirspace nuevoFormulario = new GridForAirspace();
            //nuevoFormulario.SetFlightPlans(FlightPlanList this.miLista);
            nuevoFormulario.SetData(miLista);
            nuevoFormulario.SetFlightPlans();
            nuevoFormulario.Show();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < vuelos.Length)
            {
                if (vuelos[i] == sender)
                {
                    break;
                }
                else
                {
                    i++;
                }
            }

            try
            {
                Informacion nuevoFormulario = new Informacion(this, miLista.GetFlightPlan(i));
                nuevoFormulario.Show();
                //this.Hide();
            }
            catch
            {
                MessageBox.Show("Id no encontrada.");
            }
        }

        private void botonVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
