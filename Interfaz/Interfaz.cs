using InterfazDatos;

namespace Interfaz
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterfazDatos nuevoFormulario = new InterfazDatos();
            nuevoFormulario.Show();
        }
    }
}
