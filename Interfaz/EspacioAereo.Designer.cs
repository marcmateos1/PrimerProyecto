namespace Interfaz
{
    partial class EspacioAereo
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
            panel1 = new Panel();
            botonMover = new Button();
            botonVolver = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(27, 33);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 700);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // botonMover
            // 
            botonMover.Location = new Point(1058, 246);
            botonMover.Margin = new Padding(3, 4, 3, 4);
            botonMover.Name = "botonMover";
            botonMover.Size = new Size(97, 33);
            botonMover.TabIndex = 1;
            botonMover.Text = "Mover";
            botonMover.UseVisualStyleBackColor = true;
            botonMover.Click += botonMover_Click;
            // 
            // botonVolver
            // 
            botonVolver.Location = new Point(1094, 402);
            botonVolver.Name = "botonVolver";
            botonVolver.Size = new Size(106, 30);
            botonVolver.TabIndex = 2;
            botonVolver.Text = "Volver";
            botonVolver.UseVisualStyleBackColor = true;
            botonVolver.Click += botonVolver_Click;
            // 
            // EspacioAereo
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 790);
            Controls.Add(botonVolver);
            Controls.Add(botonMover);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EspacioAereo";
            Text = "EspacioAereo";
            Load += EspacioAereo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button botonMover;
        private Button botonVolver;
    }
}