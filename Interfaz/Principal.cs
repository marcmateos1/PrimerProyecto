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
        private void Principal_Load(object sender, EventArgs e)
        {

        }


        private void introducirDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazDatos.Datos nuevoFormulario = new InterfazDatos.Datos(lista, this);
            nuevoFormulario.Show();
            this.Hide();
        }

        private void seguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Seguridad nuevoFormulario = new Seguridad(this);
            nuevoFormulario.Show();
            this.Hide();
        }

        private void espacioAereoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EspacioAereo nuevoFormulario = new EspacioAereo(this);
            nuevoFormulario.SetData(lista, tiempoCiclo);
            nuevoFormulario.Show();
            this.Hide();
        }

        private void mostrarInformacionVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Informacion nuevoFormulario = new Informacion(this, lista.SearchID((textoID.Text)));
                nuevoFormulario.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Id no encontrada.");
            }
        }
    }
}