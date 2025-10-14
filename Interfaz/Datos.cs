using FlightLib;
using Interfaz;

namespace InterfazDatos
{
    public partial class Datos : Form
    {
        FlightPlanList lista;
        Interfaz.Principal principal;
        public Datos(FlightPlanList lista, Interfaz.Principal principal)
        {
            InitializeComponent();
            this.lista = lista;
            this.principal = principal;
        }

        private void BCompilar_Click_1(object sender, EventArgs e)
        {
            try
            {
                lista.Clean();
                FlightPlan plan = new FlightPlan(TIdentificador.Text, Convert.ToDouble(TX0.Text), Convert.ToDouble(TY0.Text), Convert.ToDouble(TXF.Text), Convert.ToDouble(TYF.Text), Convert.ToDouble(TVelocidad.Text));
                lista.AddFlightPlan(plan);
                FlightPlan plan2 = new FlightPlan(TIdentificador2.Text, Convert.ToDouble(TX02.Text), Convert.ToDouble(TY02.Text), Convert.ToDouble(TXF2.Text), Convert.ToDouble(TYF2.Text), Convert.ToDouble(TVelocidad2.Text));
                lista.AddFlightPlan(plan2);

                MessageBox.Show("Plan de vuelo añadido correctamente.");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error de formato.");
            }

            //principal.Show();
        }

        private void atajo_Click(object sender, EventArgs e)
        {
            TIdentificador.Text = "Avion1";
            TY0.Text = "100";
            TX0.Text = "50";
            TYF.Text = "200";
            TXF.Text = "400";
            TVelocidad.Text = "120";

            TIdentificador2.Text = "Avion2";
            TY02.Text = "400";
            TX02.Text = "100";
            TYF2.Text = "200";
            TXF2.Text = "225";
            TVelocidad2.Text = "100";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
