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
    public partial class InicioSesionRegistro : Form
    {
        private UserList users;

        public InicioSesionRegistro()
        {
            InitializeComponent();

            string dbFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.db"); // misma ruta que Program.cs
            users = new UserList(dbFile);

            panelInicioSesion.Visible = true;
            panelRegistro.Visible = false;
        }

        // Iniciar sesión
        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            string user = textUsuario.Text.Trim();
            string pass = textContraseña.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Rellena usuario y contraseña.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); //retorna el missatge si no sha entrat correctament
                return;
            }

            // Conecta con la base de datos

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
                MessageBox.Show("Usuario o contraseña incorrectos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Registro

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            panelInicioSesion.Visible = false;
            panelRegistro.Visible = true;

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
                MessageBox.Show("Rellena usuario y contraseña.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (users.UsernameExists(user))
            {
                MessageBox.Show("Ese usuario ya existe.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass.Length < 4)
            {
                MessageBox.Show("La contraseña debe tener al menos 4 caracteres.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            users.AddUser(new User(user, pass));

            MessageBox.Show("Usuario creado correctamente.", "Registro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);



            MessageBox.Show("Usuario creado correctamente.", "Registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Volver a pantalla de inicio de sesión
            panelRegistro.Visible = false;
            panelInicioSesion.Visible = true;

            textUsuario.Text = user;
            textContraseña.Text = "";
        }

        private void textInicioSesion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}