using FlightLib;

namespace InterfazDatos
{
    public partial class InterfazDatos : Form
    {
        public InterfazDatos()
        {
            InitializeComponent();
        }

        private void BCompilar_Click(object sender, EventArgs e, FlightPlanList lista)
        {
            FlightPlan plan = new FlightPlan(TIdentificador.Text, Convert.ToDouble(TVelocidad.Text), Convert.ToDouble(TX0.Text), Convert.ToDouble(TY0.Text), Convert.ToDouble(TXF.Text), Convert.ToDouble(TYF.Text));
            lista.AddFlightPlan(plan);
        }
    }
}
