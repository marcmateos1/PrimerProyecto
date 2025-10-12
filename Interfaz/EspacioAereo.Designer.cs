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
            panel1.Location = new Point(24, 31);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 667);
            panel1.TabIndex = 0;
            // 
            // botonMover
            // 
            botonMover.Location = new Point(980, 230);
            botonMover.Margin = new Padding(3, 4, 3, 4);
            botonMover.Name = "botonMover";
            botonMover.Size = new Size(86, 31);
            botonMover.TabIndex = 1;
            botonMover.Text = "Mover";
            botonMover.UseVisualStyleBackColor = true;
            botonMover.Click += botonMover_Click;
            // 
            // botonVolver
            // 
            botonVolver.Location = new Point(972, 383);
            botonVolver.Name = "botonVolver";
            botonVolver.Size = new Size(94, 29);
            botonVolver.TabIndex = 2;
            botonVolver.Text = "Volver";
            botonVolver.UseVisualStyleBackColor = true;
            botonVolver.Click += botonVolver_Click;
            // 
            // EspacioAereo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 752);
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