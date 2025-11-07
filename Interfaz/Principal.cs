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
            //this.Hide();
        }

        private void seguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Seguridad nuevoFormulario = new Seguridad(this);
            nuevoFormulario.Show();
            //this.Hide();
        }

        private void espacioAereoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                EspacioAereo nuevoFormulario = new EspacioAereo(this);
                nuevoFormulario.SetData(lista, tiempoCiclo, distanciaSeguridad);
                nuevoFormulario.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Entra correctament totes els dades");
            }
            //this.Hide();
        }

        private void cargarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilenameCargarLista nuevoFormulario = new FilenameCargarLista();
            nuevoFormulario.ShowDialog();
            int resultado = lista.CargarLista(nuevoFormulario.filename + ".txt");
            if (resultado == -2)
            {
                MessageBox.Show("Error de formato en el documento de texto.");
            }
            else if (resultado == -1)
            {
                MessageBox.Show("No se ha encontrado dicho documento.");
            }
            else
            {
                lista.Clean();
                lista.CargarLista(nuevoFormulario.filename + ".txt");
                MessageBox.Show("Lista cargada correctamente.");
            }
        }
    }
}