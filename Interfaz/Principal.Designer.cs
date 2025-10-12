namespace Interfaz
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            cargarFicheroToolStripMenuItem = new ToolStripMenuItem();
            parametrosToolStripMenuItem = new ToolStripMenuItem();
            seguridadToolStripMenuItem = new ToolStripMenuItem();
            espacioAereoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            opcionesToolStripMenuItem1 = new ToolStripMenuItem();
            introducirDatosToolStripMenuItem = new ToolStripMenuItem();
            seguridadToolStripMenuItem1 = new ToolStripMenuItem();
            espacioAereoToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(305, 24);
            menuStrip1.TabIndex = 3;
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(32, 19);
            // 
            // cargarFicheroToolStripMenuItem
            // 
            cargarFicheroToolStripMenuItem.Name = "cargarFicheroToolStripMenuItem";
            cargarFicheroToolStripMenuItem.Size = new Size(32, 19);
            // 
            // parametrosToolStripMenuItem
            // 
            parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            parametrosToolStripMenuItem.Size = new Size(32, 19);
            // 
            // seguridadToolStripMenuItem
            // 
            seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            seguridadToolStripMenuItem.Size = new Size(32, 19);
            // 
            // espacioAereoToolStripMenuItem
            // 
            espacioAereoToolStripMenuItem.Name = "espacioAereoToolStripMenuItem";
            espacioAereoToolStripMenuItem.Size = new Size(32, 19);
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(305, 24);
            menuStrip2.TabIndex = 4;
            menuStrip2.Text = "menuStrip2";
            // 
            // opcionesToolStripMenuItem1
            // 
            opcionesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { introducirDatosToolStripMenuItem, seguridadToolStripMenuItem1, espacioAereoToolStripMenuItem1 });
            opcionesToolStripMenuItem1.Name = "opcionesToolStripMenuItem1";
            opcionesToolStripMenuItem1.Size = new Size(69, 20);
            opcionesToolStripMenuItem1.Text = "Opciones";
            // 
            // introducirDatosToolStripMenuItem
            // 
            introducirDatosToolStripMenuItem.Name = "introducirDatosToolStripMenuItem";
            introducirDatosToolStripMenuItem.Size = new Size(159, 22);
            introducirDatosToolStripMenuItem.Text = "Introducir Datos";
            introducirDatosToolStripMenuItem.Click += introducirDatosToolStripMenuItem_Click;
            // 
            // seguridadToolStripMenuItem1
            // 
            seguridadToolStripMenuItem1.Name = "seguridadToolStripMenuItem1";
            seguridadToolStripMenuItem1.Size = new Size(159, 22);
            seguridadToolStripMenuItem1.Text = "Seguridad";
            seguridadToolStripMenuItem1.Click += seguridadToolStripMenuItem1_Click;
            // 
            // espacioAereoToolStripMenuItem1
            // 
            espacioAereoToolStripMenuItem1.Name = "espacioAereoToolStripMenuItem1";
            espacioAereoToolStripMenuItem1.Size = new Size(159, 22);
            espacioAereoToolStripMenuItem1.Text = "Espacio Aereo";
            espacioAereoToolStripMenuItem1.Click += espacioAereoToolStripMenuItem1_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 312);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Principal";
            Text = "Air Traffic Simulator";
            Load += Principal_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem cargarFicheroToolStripMenuItem;
        private ToolStripMenuItem parametrosToolStripMenuItem;
        private ToolStripMenuItem seguridadToolStripMenuItem;
        private ToolStripMenuItem espacioAereoToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem opcionesToolStripMenuItem1;
        private ToolStripMenuItem introducirDatosToolStripMenuItem;
        private ToolStripMenuItem seguridadToolStripMenuItem1;
        private ToolStripMenuItem espacioAereoToolStripMenuItem1;
    }
}
