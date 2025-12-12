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
            volverbttndeInfoVuelos = new Button();
            ((System.ComponentModel.ISupportInitialize)Taula).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Taula
            // 
            Taula.Anchor = AnchorStyles.None;
            Taula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Taula.Location = new Point(29, 101);
            Taula.Margin = new Padding(3, 4, 3, 4);
            Taula.Name = "Taula";
            Taula.RowHeadersWidth = 51;
            Taula.Size = new Size(842, 273);
            Taula.TabIndex = 0;
            Taula.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(volverbttndeInfoVuelos);
            groupBox1.Controls.Add(Taula);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, 29);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(890, 477);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMACIÓN DE TODOS LOS VUELOS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // volverbttndeInfoVuelos
            // 
            volverbttndeInfoVuelos.Location = new Point(400, 416);
            volverbttndeInfoVuelos.Name = "volverbttndeInfoVuelos";
            volverbttndeInfoVuelos.Size = new Size(94, 29);
            volverbttndeInfoVuelos.TabIndex = 1;
            volverbttndeInfoVuelos.Text = "Volver";
            volverbttndeInfoVuelos.UseVisualStyleBackColor = true;
            volverbttndeInfoVuelos.Click += volverbttndeInfoVuelos_Click;
            // 
            // GridForAirspace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 521);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GridForAirspace";
            Text = "GridForAirspace";
            WindowState = FormWindowState.Maximized;
            Load += GridForAirspace_Load;
            ((System.ComponentModel.ISupportInitialize)Taula).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Taula;
        private GroupBox groupBox1;
        private Button volverbttndeInfoVuelos;
    }
}