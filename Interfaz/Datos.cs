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
                FlightPlan plan = new FlightPlan(TIdentificador.Text, Convert.ToDouble(TVelocidad.Text), Convert.ToDouble(TX0.Text), Convert.ToDouble(TY0.Text), Convert.ToDouble(TXF.Text), Convert.ToDouble(TYF.Text));
                lista.AddFlightPlan(plan);
                MessageBox.Show("Plan de vuelo añadido correctamente.");
            }
            catch
            {
                MessageBox.Show("Error de formato.");
            }
            this.Close();
            principal.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
