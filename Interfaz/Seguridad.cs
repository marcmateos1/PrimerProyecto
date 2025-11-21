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
    public partial class Seguridad : Form
    {
        //iniciar les dades
        Interfaz.Principal principal;
        int tiempoCiclo = 0;
        int distanciaSeguridad = 0;
        public Seguridad(Interfaz.Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }
        private void Seguridad_Load(object sender, EventArgs e)
        {
            if (principal.tiempoCiclo != 0 && principal.distanciaSeguridad != 0)
            {
                textTiempo.Text = Convert.ToString(principal.tiempoCiclo);
                textDistancia.Text = Convert.ToString(principal.distanciaSeguridad);
            }
        }

        private void botonDistancia_Click(object sender, EventArgs e)
        {
            //posar els valors dels textbox al flightplan
            try
            {
                if (Convert.ToInt32(textTiempo.Text) > 0 && Convert.ToInt32(textDistancia.Text) > 0)
                {
                    tiempoCiclo = Convert.ToInt32(textTiempo.Text);
                    distanciaSeguridad = Convert.ToInt32(textDistancia.Text);
                    MessageBox.Show("Datos cargados correctamente.");
                    principal.tiempoCiclo = tiempoCiclo;
                    principal.distanciaSeguridad = distanciaSeguridad;
                }
                else
                {
                    MessageBox.Show("No se admiten datos negativos.");
                }
            }
            catch
            {
                MessageBox.Show("Error de formato.");
            }
            this.Close();
        }

        private void botonAtajo_Click(object sender, EventArgs e)
        {
            //boto atajo per anar mes rapid, que dona uns valors de base
            textDistancia.Text = "100";
            textTiempo.Text = "10";
        }


    }
}
