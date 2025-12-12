using System;
using System.Windows.Forms;
using FlightLib;

namespace Interfaz
{
    public partial class Empresa : Form
    {
        BaseDeDatos db;
        CompaniesList companies;

        public Empresa()
        {
            InitializeComponent();
        }

        public void SetData(BaseDeDatos db)
        {
            this.db = db;
            companies = new CompaniesList(db);
        }

        private void registrar_Click_1(object sender, EventArgs e)
        {
            string name = regNom.Text.Trim();
            string mail = regMail.Text.Trim();

            // Validación teléfono
            string telfStr = regTel.Text.Trim();
            if (string.IsNullOrEmpty(telfStr))
            {
                MessageBox.Show("El teléfono no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación campos
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Rellena todos los parámetros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Añadir empresa
                companies.AddCompany(new Companies(name, telfStr, mail));
                MessageBox.Show("Empresa registrada correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                regNom.Text = "";
                regTel.Text = "";
                regMail.Text = "";
            }
            catch (Exception ex)
            {
                // Mostrar error si el nombre, teléfono o correo ya existen
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttnCancelarDatosEmpresa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}