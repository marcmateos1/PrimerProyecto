using FlightLib;

namespace Interfaz
{
    public partial class Principal : Form
    {

        // Atributos
        FlightPlanList lista = new FlightPlanList();
        public int distanciaSeguridad;
        public int tiempoCiclo;
        BaseDeDatos db;
        string a;



        // Constructor
        public Principal()
        {
            InitializeComponent();
        }


        private void introducirDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir el formulario de introducir datos
            InterfazDatos.Datos nuevoFormulario = new InterfazDatos.Datos(lista, this);
            nuevoFormulario.Show();
            //this.Hide();
        }

        private void seguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Abrir el formulario de seguridad
            Seguridad nuevoFormulario = new Seguridad(this);
            nuevoFormulario.Show();
        }

        private void espacioAereoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Abrir el espacio aéreo
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
            // Cargar los vuelos desde un archivo de texto
            OpenFileDialog nuevoFormulario = new OpenFileDialog();
            nuevoFormulario.Title = "Cargar Lista de Vuelos";
            nuevoFormulario.Filter = "Archivos de Texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"; //Muestra los archivos .txt
            nuevoFormulario.DefaultExt = "txt";
            nuevoFormulario.CheckFileExists = true;
            nuevoFormulario.CheckPathExists = true; //Existe el archivo y la ruta

            if (nuevoFormulario.ShowDialog() == DialogResult.OK) //El usuario abre el archivo
            {
                string filePath = nuevoFormulario.FileName;
                int resultado = lista.CargarLista(filePath); //Limpia la lista y llama a la función
                if (resultado == -3)
                {
                    MessageBox.Show("No se permiten valores de velocidad negativos.");
                }
                else if (resultado == -2)
                {
                    MessageBox.Show("Error de formato en el documento de texto.");
                }
                else if (resultado == -1)
                {
                    MessageBox.Show("No se ha encontrado dicho documento.");
                }
                else if (resultado == 0)
                {
                    MessageBox.Show("Lista cargada correctamente.");
                    lista.Clean();
                    lista.CargarLista(filePath);
                }
            }
        }

        private void registrarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa(a);
            empresa.Show();
        }

        private void opcionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}