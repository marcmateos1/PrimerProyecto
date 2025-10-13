namespace Interfaz
{
    partial class GridForAirspace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Taula = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Taula).BeginInit();
            SuspendLayout();
            // 
            // Taula
            // 
            Taula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Taula.Location = new Point(100, 91);
            Taula.Name = "Taula";
            Taula.Size = new Size(543, 205);
            Taula.TabIndex = 0;
            Taula.CellContentClick += dataGridView1_CellContentClick;
            // 
            // GridForAirspace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Taula);
            Name = "GridForAirspace";
            Text = "GridForAirspace";
            Load += GridForAirspace_Load;
            ((System.ComponentModel.ISupportInitialize)Taula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Taula;
    }
}