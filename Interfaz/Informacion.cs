using FlightLib;
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
    public partial class Informacion : Form
    {

        //Atributos
        Interfaz.EspacioAereo espacioAereo;
        FlightPlanList list;
        CompaniesList cList;
        Companies c;
        int posicion;
        BaseDeDatos db;


        //Constructor
        public Informacion(Interfaz.EspacioAereo espacioAereo, FlightPlanList list, int posicion, BaseDeDatos db)
        {
            //iniciar el forms i inicializar las clases necesarias
            InitializeComponent();
            this.espacioAereo = espacioAereo;
            this.list = list;
            this.posicion = posicion;
            this.db = db;
        }


        private void Informacion_Load_1(object sender, EventArgs e)
        {
            FlightPlan plan = list.GetFlightPlan(posicion);
            // Rellenar los labels con la información del flightplan
            label1.Text = $"Id: {plan.GetId()}";
            string ID = plan.GetId();
            velocidadBox.Text = Convert.ToString(plan.GetVelocidad());
            label3.Text = $"X actual: {plan.GetCurrentPosition().GetX():F2}";
            label4.Text = $"X final: {plan.GetFinalPosition().GetX():F2}";
            label5.Text = $"Y actual: {plan.GetCurrentPosition().GetY():F2}";
            label6.Text = $"Y final: {plan.GetFinalPosition().GetY():F2}";
            label7.Text = $"X inicial: {plan.GetInitialPosition().GetX():F2}";
            label8.Text = $"Y inicial: {plan.GetInitialPosition().GetY():F2}";
            Companies emp = new CompaniesList(db).GetCompanyByName(plan.GetNom());

            // Labels con información de empresa
            if (emp != null)
            {
                nom.Text = $"Nombre: {emp.GetName()}";
                string name=emp.GetName();
                telf.Text = $"Teléfono: {emp.GetTel()}";
                string tel = emp.GetTel();
                mail.Text = $"eMail: {emp.GetEmail()}";
                string email=emp.GetEmail();
            }
            else
            {
                nom.Text = "Nombre: DESCONOCIDO";
                telf.Text = "Teléfono: DESCONOCIDO";
                mail.Text = "eMail: DESCONOCIDO";
            }



        }


        // Volver a principal
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            espacioAereo.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Actualizar la velocidad dentro del forms
            try
            {
                double speed = Convert.ToDouble(velocidadBox.Text);

                if (speed >= 0)
                {
                    list.GetFlightPlan(posicion).SetVelocidad(speed);
                    MessageBox.Show("Velocidad actualizada");
                }
                else
                    MessageBox.Show("La velocidad debe ser un valor positivo");
            }

            catch (FormatException)
            {
                MessageBox.Show("Formato de velocidad no válido");
            }
        }


        public FlightPlanList MyList() //retorna la lista
        {
            return list;
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            //enviar un txt a la empresa con el cambio de velocidad
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Ficheros de texto (*.txt)|*.txt";
            saveFileDialog.Title = "Guardar Fichero de Texto";

            FlightPlan plan = list.GetFlightPlan(posicion); //declarar flightplan
            Companies emp = new CompaniesList(db).GetCompanyByName(plan.GetNom()); //declarar compañias aereas


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta=saveFileDialog.FileName;

                string ID=plan.GetId();
                string V = Convert.ToString(plan.GetVelocidad());
                string nom=emp.GetName();
                string tel=emp.GetTel();
                string mail = emp.GetEmail();

                //escribir contenido en el fichero

                try
                {
                    StreamWriter W = new StreamWriter(ruta);
                    W.WriteLine("Se ha cambiado la velocidad del avión con ID {0}. La nueva velocidad es: {1}", ID, V);
                    W.WriteLine("   Para contactar con la compañía aérea: ");
                    W.WriteLine("       Nombre de la compañía: {0}",nom);
                    W.WriteLine("       Teléfono de la compañía: {0}",tel);
                    W.WriteLine("       Correo de la compañía: {0}",mail);
                    W.Close();
                } catch(Exception ex) {MessageBox.Show("Error en crear el Fichero: "+ex.Message); }

            }

        }
    }
}
