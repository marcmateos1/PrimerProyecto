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
    public partial class FilenameCargarLista : Form
    {
        public string filename;
        public FilenameCargarLista()
        {
            InitializeComponent();
        }

        private void cargarBtn_Click(object sender, EventArgs e)
        {
            filename = fileNameBox.Text; //Guarda el nombre en una variable publica para poder ser accedida desde el principal o el espacio aereo
            this.Close();
        }
    }
}
