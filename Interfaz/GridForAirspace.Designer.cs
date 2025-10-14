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
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)Taula).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Taula
            // 
            Taula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Taula.Location = new Point(56, 45);
            Taula.Name = "Taula";
            Taula.Size = new Size(543, 205);
            Taula.TabIndex = 0;
            Taula.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Taula);
            groupBox1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(76, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 303);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de todos los vuelos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // GridForAirspace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "GridForAirspace";
            Text = "GridForAirspace";
            Load += GridForAirspace_Load;
            ((System.ComponentModel.ISupportInitialize)Taula).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Taula;
        private GroupBox groupBox1;
    }
}