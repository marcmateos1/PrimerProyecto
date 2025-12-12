using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightLib;
using System.Data.SQLite;


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

        private void registrar_Click(object sender, EventArgs e)
        {
            string name = regNom.Text.Trim();
            string mail = regMail.Text.Trim();

            // Validación teléfono
            if (!int.TryParse(regTel.Text.Trim(), out int telf))
            {
                MessageBox.Show("El teléfono debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string telfStr = regTel.Text.Trim();
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