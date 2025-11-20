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

            string userFile = Path.Combine(Environment.CurrentDirectory, "users.txt");
            users = new UserList(userFile);

            panelInicioSesion.Visible = true;
            panelRegistro.Visible = false;
        }

        // Iniciar sesión
        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            string user = textInicioSesion.Text.Trim();
            string pass = textContraseña.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Rellena usuario y contraseña.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (users.Authenticate(user, pass))
            {
                MessageBox.Show("Inicio de sesión correcto.", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el menú principal
                Principal menu = new Principal();
                menu.Show();

                this.Hide(); // Oculta el login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error",
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

            // Crear usuario y guardar
            users.AddUser(new User(user, pass));
            users.SaveToFile();

            MessageBox.Show("Usuario creado correctamente.", "Registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Volver a pantalla de inicio de sesión
            panelRegistro.Visible = false;
            panelInicioSesion.Visible = true;

            textInicioSesion.Text = user;
            textContraseña.Text = "";
        }
    }
}