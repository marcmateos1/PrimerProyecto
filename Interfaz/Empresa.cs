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


namespace Interfaz
{
    public partial class Empresa : Form
    {
        BaseDeDatos db;
        CompaniesList companies;

        public Empresa()
        {
            InitializeComponent();

            PanelLogInEmpresa.BackColor = Color.FromArgb(255, Color.White);
            PanelRegEmpresa.BackColor = Color.FromArgb(100, Color.White);
            PanelLogInEmpresa.BorderStyle = BorderStyle.FixedSingle;
            PanelRegEmpresa.BorderStyle = BorderStyle.None;
            PanelLogInEmpresa.Enabled = true;
            PanelRegEmpresa.Enabled = false;
        }

        public void SetData(BaseDeDatos db)
        {
            this.db = db;
            companies = new CompaniesList(db);
        }


        private void logInBut_Click(object sender, EventArgs e)
        {
            string name = logInNom.Text.Trim();
            string mail = logInMail.Text.Trim();

            // Validación del teléfono
            if (!int.TryParse(logInTel.Text.Trim(), out int telf))
            {
                MessageBox.Show("El teléfono debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación general
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Rellena todos los parámetros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Autenticación
            if (companies.Authenticate(name, telf, mail))
            {
                MessageBox.Show("Login correcto");

                Principal menu = new Principal();
                menu.SetDat(db);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void anarAreg_Click_1(object sender, EventArgs e)
        {
            // Mostrar panel registro como activo
            PanelRegEmpresa.BackColor = Color.FromArgb(255, Color.White);
            PanelLogInEmpresa.BackColor = Color.FromArgb(100, Color.White);

            PanelRegEmpresa.Enabled = true;
            PanelLogInEmpresa.Enabled = false;

            PanelRegEmpresa.BorderStyle = BorderStyle.FixedSingle;
            PanelLogInEmpresa.BorderStyle = BorderStyle.None;

            // Limpiar campos de registro
            regNom.Text = "";
            regTel.Text = "";
            regMail.Text = "";
        }


        private void registrar_Click_1(object sender, EventArgs e)
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

            // Comprobar si ya existe
            if (companies.nameExsits(name))
            {
                MessageBox.Show("Esta empresa ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Añadir empresa
            companies.AddCompany(new Companies(name, telf, mail));

            MessageBox.Show("Empresa registrada correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Volver al LOGIN
            PanelLogInEmpresa.BackColor = Color.FromArgb(255, Color.White);
            PanelRegEmpresa.BackColor = Color.FromArgb(100, Color.White);

            PanelLogInEmpresa.Enabled = true;
            PanelRegEmpresa.Enabled = false;

            PanelLogInEmpresa.BorderStyle = BorderStyle.FixedSingle;
            PanelRegEmpresa.BorderStyle = BorderStyle.None;

            // Autorrellenar login con los datos recién registrados
            logInNom.Text = name;
            logInTel.Text = telf.ToString();
            logInMail.Text = mail;
        }


        private void Cancelar_Click(object sender, EventArgs e)
        {
            PanelLogInEmpresa.BackColor = Color.FromArgb(255, Color.White);
            PanelRegEmpresa.BackColor = Color.FromArgb(100, Color.White);

            PanelLogInEmpresa.Enabled = true;
            PanelRegEmpresa.Enabled = false;

            PanelLogInEmpresa.BorderStyle = BorderStyle.FixedSingle;
            PanelRegEmpresa.BorderStyle = BorderStyle.None;
        }

        private void bttnCancelarDatosEmpresa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
