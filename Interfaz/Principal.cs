using FlightLib;

namespace Interfaz
{
    public partial class Principal : Form
    {
        FlightPlanList lista = new FlightPlanList();
        public int distanciaSeguridad;
        public int tiempoCiclo;
        public Principal()
        {
            InitializeComponent();
        }
        private void Interfaz_Load(object sender, EventArgs e)
        {
            lista = new FlightPlanList();
        }

        private void botonDatos_Click(object sender, EventArgs e)
        {
            InterfazDatos.Datos nuevoFormulario = new InterfazDatos.Datos(lista, this);
            this.Hide();
            nuevoFormulario.Show();
        }

        private void botonDistancia_Click(object sender, EventArgs e)
        {
            Interfaz.Seguridad nuevoFormulario = new Interfaz.Seguridad(this);
            this.Hide();
            nuevoFormulario.Show();
        }
    }
}
