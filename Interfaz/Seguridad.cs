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
        int tiempoCiclo;
        int distanciaSeguridad;
        Interfaz.Principal principal;
        public Seguridad(Interfaz.Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void botonDistancia_Click(object sender, EventArgs e)
        {
            try
            {
                tiempoCiclo = Convert.ToInt32(textTiempo.Text);
                distanciaSeguridad = Convert.ToInt32(textDistancia.Text);
                MessageBox.Show("Datos cargados correctamente.");
                principal.tiempoCiclo = tiempoCiclo;
                principal.distanciaSeguridad = distanciaSeguridad;
            }
            catch
            {
                MessageBox.Show("Error de formato.");
            }
            this.Close();
            principal.Show();
        }

        private void botonAtajo_Click(object sender, EventArgs e)
        {
            textDistancia.Text = "10";
            textTiempo.Text = "10"; 
        }
    }
}
