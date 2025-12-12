using FlightLib;
using System;
using System.Data;
using System.Windows.Forms;

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
            //inicializar los datos
            this.db = db;
            companies = new CompaniesList(db);
        }

        private void registrar_Click_1(object sender, EventArgs e)
        {
            //registrar empresa
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




        // Eliminar empresa


        private void buttEliminarEmp_Click(object sender, EventArgs e)
        {
            string nombre = elimnom.Text.Trim();
            string telefono = elimtelf.Text.Trim();
            string correo = elimcorreu.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("Rellena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Escapar comillas simples para evitar errores de SQL
                nombre = nombre.Replace("'", "''");
                telefono = telefono.Replace("'", "''");
                correo = correo.Replace("'", "''");

                // Ejecutar DELETE directamente en la base de datos
                string sql = $"DELETE FROM Companies WHERE nom = '{nombre}' AND telf = '{telefono}' AND correu = '{correo}'";
                int filas = db.Execute(sql);

                if (filas > 0)
                {
                    MessageBox.Show("Empresa eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    elimnom.Text = "";
                    elimtelf.Text = "";
                    elimcorreu.Text = "";
                }
                else
                {
                    MessageBox.Show("No se encontró la empresa con esos datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnMostrarEmpresas_Click(object sender, EventArgs e)
        {
            //para mostrar la lista de empresa que tenemos (la base de datos)
            try
            {
                var dt = db.Select("SELECT * FROM Companies");

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay empresas registradas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Crear un nuevo formulario para mostrar los datos
                Form f = new Form();
                f.Text = "Empresas Registradas";
                f.Size = new Size(800, 500); // un poco más grande y ancho
                f.StartPosition = FormStartPosition.CenterScreen;

                TextBox txt = new TextBox();
                txt.Multiline = true;
                txt.ScrollBars = ScrollBars.Vertical;
                txt.Dock = DockStyle.Fill;
                txt.Font = new Font("Consolas", 11, FontStyle.Italic); // fuente en cursiva
                txt.ReadOnly = true;

                // Construir texto con separación
                string texto = "";
                foreach (DataRow row in dt.Rows)
                {
                    string nombre = row["nom"].ToString();
                    string telf = row["telf"].ToString();
                    string correo = row["correu"].ToString();

                    texto += $"Nombre: {nombre}    Tel: {telf}    Email: {correo}\r\n\r\n"; // doble salto para más separación
                }

                txt.Text = texto;
                f.Controls.Add(txt);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar empresas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
            