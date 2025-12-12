using FlightLib;
using Interfaz;

namespace InterfazDatos
{
    public partial class Datos : Form
    {


        // Atributos
        FlightPlanList lista;
        Interfaz.Principal principal;


        // Constructor (Recibe una FlightPlanList y inicializa los controles de la ventanna, si la lista tiene 2 vuelos los textbox se llenan con sus atributos)
        public Datos(FlightPlanList lista, Interfaz.Principal principal)
        {
            InitializeComponent();
            this.lista = lista;
            this.principal = principal;
            if (lista.NumElementosLista() == 2)
            {
                //Atribuir cada textbox a un atributo de cada flightplan
                TIdentificador.Text = lista.GetFlightPlan(0).GetId();
                TVelocidad.Text = lista.GetFlightPlan(0).GetVelocidad().ToString();
                TX0.Text = lista.GetFlightPlan(0).GetInitialPosition().GetX().ToString();
                TY0.Text = lista.GetFlightPlan(0).GetInitialPosition().GetY().ToString();
                TXF.Text = lista.GetFlightPlan(0).GetFinalPosition().GetX().ToString();
                TYF.Text = lista.GetFlightPlan(0).GetFinalPosition().GetY().ToString();
                TIdentificador2.Text = lista.GetFlightPlan(1).GetId();
                TVelocidad2.Text = lista.GetFlightPlan(1).GetVelocidad().ToString();
                TX02.Text = lista.GetFlightPlan(1).GetInitialPosition().GetX().ToString();
                TY02.Text = lista.GetFlightPlan(1).GetInitialPosition().GetY().ToString();
                TXF2.Text = lista.GetFlightPlan(1).GetFinalPosition().GetX().ToString();
                TYF2.Text = lista.GetFlightPlan(1).GetFinalPosition().GetY().ToString();
                textBoxcompania1.Text = lista.GetFlightPlan(0).GetNom();
                textBoxcompania2.Text = lista.GetFlightPlan(1).GetNom();
            }
        }


        private void BCompilar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TVelocidad.Text) > 0 && Convert.ToInt32(TVelocidad2.Text) > 0)
                {
                    //Meter los valores a un flightpan, y después a un flightplanlist reals
                    lista.Clean();
                    FlightPlan plan = new FlightPlan(TIdentificador.Text, Convert.ToDouble(TX0.Text), Convert.ToDouble(TY0.Text), Convert.ToDouble(TXF.Text), Convert.ToDouble(TYF.Text), Convert.ToDouble(TVelocidad.Text), textBoxcompania1.Text);
                    lista.AddFlightPlan(plan);
                    FlightPlan plan2 = new FlightPlan(TIdentificador2.Text, Convert.ToDouble(TX02.Text), Convert.ToDouble(TY02.Text), Convert.ToDouble(TXF2.Text), Convert.ToDouble(TYF2.Text), Convert.ToDouble(TVelocidad2.Text), textBoxcompania2.Text);
                    lista.AddFlightPlan(plan2);

                    MessageBox.Show("Plan de vuelo añadido correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se admiten velocidades negativas.");
                }
            }
            catch
            {
                MessageBox.Show("Error de formato."); //Para errores de formato, se piden otra vez los datos
            }
        }


        private void atajo_Click(object sender, EventArgs e)
        {
            //Tenemos un botón "atajo" para probar más rápido el código con valores predeterminados (ya que estar todo el rato poniéndolos es cansino)
            TIdentificador.Text = "Avion1";
            TY0.Text = "100";
            TX0.Text = "50";
            TYF.Text = "200";
            TXF.Text = "400";
            TVelocidad.Text = "120";
            textBoxcompania1.Text = "Empresa1";

            TIdentificador2.Text = "Avion2";
            TY02.Text = "400";
            TX02.Text = "100";
            TYF2.Text = "200";
            TXF2.Text = "225";
            TVelocidad2.Text = "100";
            textBoxcompania2.Text = "Empresa2";
        }

        private void Datos_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TYF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
