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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            botonMover = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            simularAut = new Button();
            Parar = new Button();
            Reloj = new System.Windows.Forms.Timer(components);
            ShowInfo = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(339, 38);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 501);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // botonMover
            // 
            botonMover.Location = new Point(109, 89);
            botonMover.Margin = new Padding(2, 3, 2, 3);
            botonMover.Name = "botonMover";
            botonMover.Size = new Size(106, 52);
            botonMover.TabIndex = 1;
            botonMover.Text = "Mover una iteración";
            botonMover.UseVisualStyleBackColor = true;
            botonMover.Click += botonMover_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(311, 38);
            label1.Name = "label1";
            label1.Size = new Size(23, 28);
            label1.TabIndex = 3;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(339, 7);
            label2.Name = "label2";
            label2.Size = new Size(23, 28);
            label2.TabIndex = 4;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(289, 510);
            label3.Name = "label3";
            label3.Size = new Size(45, 28);
            label3.TabIndex = 5;
            label3.Text = "500";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(794, 7);
            label4.Name = "label4";
            label4.Size = new Size(45, 28);
            label4.TabIndex = 6;
            label4.Text = "500";
            // 
            // simularAut
            // 
            simularAut.Location = new Point(109, 178);
            simularAut.Name = "simularAut";
            simularAut.Size = new Size(106, 55);
            simularAut.TabIndex = 7;
            simularAut.Text = "Simular Automaticmente";
            simularAut.UseVisualStyleBackColor = true;
            simularAut.Click += simularAut_Click;
            // 
            // Parar
            // 
            Parar.Location = new Point(109, 274);
            Parar.Name = "Parar";
            Parar.Size = new Size(106, 51);
            Parar.TabIndex = 8;
            Parar.Text = "Parar";
            Parar.UseVisualStyleBackColor = true;
            Parar.Click += Parar_Click;
            // 
            // Reloj
            // 
            Reloj.Interval = 1;
            Reloj.Tick += Reloj_Tick_1;
            // 
            // ShowInfo
            // 
            ShowInfo.Location = new Point(109, 368);
            ShowInfo.Name = "ShowInfo";
            ShowInfo.Size = new Size(106, 51);
            ShowInfo.TabIndex = 9;
            ShowInfo.Text = "Muestra datos de los vuelos";
            ShowInfo.UseVisualStyleBackColor = true;
            ShowInfo.Click += ShowInfo_Click;
            // 
            // EspacioAereo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 568);
            Controls.Add(ShowInfo);
            Controls.Add(Parar);
            Controls.Add(simularAut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botonMover);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "EspacioAereo";
            Text = "EspacioAereo";
            Load += EspacioAereo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button botonMover;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button simularAut;
        private Button Parar;
        private System.Windows.Forms.Timer Reloj;
        private Button ShowInfo;
    }
}