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
        Companies c;
        CompaniesList companies;
        public Empresa()
        {
            InitializeComponent();

            PanelLogInEmpresa.BackColor = Color.FromArgb(255, Color.White); // visible
            PanelRegEmpresa.BackColor = Color.FromArgb(100, Color.White);
            PanelLogInEmpresa.BorderStyle = BorderStyle.FixedSingle; // panel activo con borde
            PanelRegEmpresa.BorderStyle = BorderStyle.None;           // panel inactivo sin borde


        }
        public void SetData(BaseDeDatos db)
        {
            this.db = db;
            companies = new CompaniesList(db);
        }


        // Entrar empresa

        private void logInBut_Click(object sender, EventArgs e)
        {
            // Validar entrada
            string name = logInNom.Text.Trim();
            int telf = Convert.ToInt32(logInTel.Text.Trim());
            string mail = logInMail.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(Convert.ToString(telf)) || string.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Rellena todos los parámetros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); //retorna el missatge si no sha entrat correctament
                return;
            }

            // Nos connectamos con la base de datos

            if (companies.Authenticate(name, telf, mail))
            {
                MessageBox.Show("Login correcto");
                // Aquí abrirías el menú principal
                Principal menu = new Principal();
                menu.Show();
                this.Hide(); // Oculta el login
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Ir a registrar empresa
        private void anarAreg_Click_1(object sender, EventArgs e)
        {
            PanelLogInEmpresa.BackColor = Color.FromArgb(255, Color.White); // visible
            PanelRegEmpresa.BackColor = Color.FromArgb(100, Color.White);
            PanelLogInEmpresa.BorderStyle = BorderStyle.FixedSingle; // panel activo con borde
            PanelRegEmpresa.BorderStyle = BorderStyle.None;           // panel inactivo sin borde


            regNom.Text = "";
            regTel.Text = "";
            regMail.Text = "";
        }

        //registrar nueva empresa
        private void registrar_Click_1(object sender, EventArgs e)
        {
            string name = logInNom.Text.Trim();
            int telf = Convert.ToInt32(logInTel.Text.Trim());
            string mail = logInMail.Text;


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(Convert.ToString(telf)) || string.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Rellena todos los parámetros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); //retorna el missatge si no sha entrat correctament
                return;
            }

            if (companies.nameExsits(name))
            {
                MessageBox.Show("Esta empresa ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            companies.AddCompany(new Companies(name, telf, mail));

            MessageBox.Show("Usuario creado correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Volver a pantalla de inicio de sesiónn

            PanelRegEmpresa.BackColor = Color.FromArgb(255, Color.White); // visible
            PanelLogInEmpresa.BackColor = Color.FromArgb(100, Color.White);
            PanelRegEmpresa.BorderStyle = BorderStyle.FixedSingle; // panel activo con borde
            PanelLogInEmpresa.BorderStyle = BorderStyle.None;           // panel inactivo sin borde


            // Rellenar el campo de usuario y limpiar la contraseña
            logInNom.Text = name;
            logInTel.Text = Convert.ToString(telf);
            logInMail.Text = mail;
        }

        //cancelar registro
        private void Cancelar_Click(object sender, EventArgs e)
        {
            PanelLogInEmpresa.BackColor = Color.FromArgb(255, Color.White); // visible
            PanelRegEmpresa.BackColor = Color.FromArgb(100, Color.White);
            PanelLogInEmpresa.BorderStyle = BorderStyle.FixedSingle; // panel activo con borde
            PanelRegEmpresa.BorderStyle = BorderStyle.None;           // panel inactivo sin borde
        }

        private void RegEmpresa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Empresa_Load(object sender, EventArgs e)
        {

        }
    }
}
