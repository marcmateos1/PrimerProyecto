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

            panelInicioSesion.Visible = true;
            panelRegistro.Visible = false;
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
            panelInicioSesion.Visible = false;
            panelRegistro.Visible = true; //Ponemos invisible el panel de inicio de sesión y visible el de registro

            textNuevoUsuario.Text = "";
            NuevaContraseña.Text = "";
        }


        // Cancelar Registro
        private void buttonCancelarRegistro_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
            panelInicioSesion.Visible = true;
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

            // Volver a pantalla de inicio de sesiónn
            panelRegistro.Visible = false;
            panelInicioSesion.Visible = true;

            // Rellenar el campo de usuario y limpiar la contraseña
            textUsuario.Text = user;
            textContraseña.Text = "";
        }
    }
}