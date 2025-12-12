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
    public partial class InicioSesionRegistro : Form
    {

        // Atributos
        BaseDeDatos db;
        ListaUsuarios users;


        // Recibe la ruta del archivo de base de datos
        public InicioSesionRegistro(string dbFile)
        {
            InitializeComponent();

            // Inicializar Database, UserList y CompaniesList
            db = new BaseDeDatos(dbFile);  // constructor modificado para aceptar ruta
            users = new ListaUsuarios(db);


            panelInicioSesion.BackColor = Color.FromArgb(255, Color.White); // visible
            panelInicioSesion.Enabled = true; // activar panel inicio de sesión
            panelRegistro.BackColor = Color.FromArgb(100, Color.White);
            panelRegistro.Enabled = false;
            panelInicioSesion.BorderStyle = BorderStyle.FixedSingle; // panel activo con borde
            panelRegistro.BorderStyle = BorderStyle.None;           // panel inactivo sin borde

        }


        // Iniciar sesión
        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            // Validar entrada
            string user = textUsuario.Text.Trim();
            string pass = textContraseña.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Rellena usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); //retorna el missatge si no sha entrat correctament
                return;
            }

            // Nos connectamos con la base de datos

            if (users.Authenticate(user, pass))
            {
                MessageBox.Show("Login correcto");
                // Aquí abrirías el menú principal
                Principal menu = new Principal();
                menu.SetDat(db);
                menu.Show();
                this.Hide(); // Oculta el login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Registrarse
        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {

            panelRegistro.BackColor = Color.FromArgb(255, Color.White); // visible
            panelRegistro.Enabled = true;
            panelRegistro.BorderStyle = BorderStyle.FixedSingle;    // ahora panel registro activo
            panelInicioSesion.BackColor = Color.FromArgb(100, Color.White);
            panelInicioSesion.Enabled = false; // activar panel inicio de sesión
            panelInicioSesion.BorderStyle = BorderStyle.None;

            textNuevoUsuario.Text = "";
            NuevaContraseña.Text = "";
        }


        // Cancelar Registro
        private void buttonCancelarRegistro_Click(object sender, EventArgs e)
        {

            panelInicioSesion.BackColor = Color.FromArgb(255, Color.White); // visible
            panelInicioSesion.Enabled = true; // activar panel inicio de sesión
            panelRegistro.BackColor = Color.FromArgb(100, Color.White);
            panelRegistro.Enabled = false;
            panelInicioSesion.BorderStyle = BorderStyle.FixedSingle; // panel activo con borde
            panelRegistro.BorderStyle = BorderStyle.None;           // panel inactivo sin borde

        }


        // Crear Usuario
        private void buttonCrearUsuario_Click(object sender, EventArgs e)
        {
            string user = textNuevoUsuario.Text.Trim();
            string pass = NuevaContraseña.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Rellena usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (users.UsernameExists(user))
            {
                MessageBox.Show("Ese usuario ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass.Length < 4)
            {
                MessageBox.Show("La contraseña debe tener al menos 4 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            users.AddUser(new Usuarios(user, pass));

            MessageBox.Show("Usuario creado correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Volver a pantalla de inicio de sesión

            panelInicioSesion.BackColor = Color.FromArgb(255, Color.White); // visible
            panelInicioSesion.Enabled = true; // activar panel inicio de sesión
            panelRegistro.BackColor = Color.FromArgb(100, Color.White);
            panelRegistro.Enabled = false;
            panelInicioSesion.BorderStyle = BorderStyle.FixedSingle; // panel activo con borde
            panelRegistro.BorderStyle = BorderStyle.None;           // panel inactivo sin borde


            // Rellenar el campo de usuario y limpiar la contraseña
            textUsuario.Text = user;
            textContraseña.Text = "";



        }


        //cerrar el forms

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}