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
            botonVolver = new Button();
            labelseg = new Label();
            ButtonRestart = new Button();
            button1 = new Button();
            botocon = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(387, 51);
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 500);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // botonMover
            // 
            botonMover.Location = new Point(125, 64);
            botonMover.Margin = new Padding(2, 4, 2, 4);
            botonMover.Name = "botonMover";
            botonMover.Size = new Size(121, 69);
            botonMover.TabIndex = 1;
            botonMover.Text = "Mover una iteración";
            botonMover.UseVisualStyleBackColor = true;
            botonMover.Click += botonMover_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(354, 51);
            label1.Name = "label1";
            label1.Size = new Size(28, 35);
            label1.TabIndex = 3;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(387, 9);
            label2.Name = "label2";
            label2.Size = new Size(28, 35);
            label2.TabIndex = 4;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(330, 680);
            label3.Name = "label3";
            label3.Size = new Size(54, 35);
            label3.TabIndex = 5;
            label3.Text = "500";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(907, 9);
            label4.Name = "label4";
            label4.Size = new Size(54, 35);
            label4.TabIndex = 6;
            label4.Text = "500";
            // 
            // simularAut
            // 
            simularAut.Location = new Point(125, 141);
            simularAut.Margin = new Padding(3, 4, 3, 4);
            simularAut.Name = "simularAut";
            simularAut.Size = new Size(121, 73);
            simularAut.TabIndex = 7;
            simularAut.Text = "Simular Automaticmente";
            simularAut.UseVisualStyleBackColor = true;
            simularAut.Click += simularAut_Click;
            // 
            // Parar
            // 
            Parar.Location = new Point(125, 222);
            Parar.Margin = new Padding(3, 4, 3, 4);
            Parar.Name = "Parar";
            Parar.Size = new Size(121, 68);
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
            ShowInfo.Location = new Point(125, 365);
            ShowInfo.Margin = new Padding(3, 4, 3, 4);
            ShowInfo.Name = "ShowInfo";
            ShowInfo.Size = new Size(121, 68);
            ShowInfo.TabIndex = 9;
            ShowInfo.Text = "Muestra datos de los vuelos";
            ShowInfo.UseVisualStyleBackColor = true;
            ShowInfo.Click += ShowInfo_Click;
            // 
            // botonVolver
            // 
            botonVolver.Location = new Point(125, 508);
            botonVolver.Name = "botonVolver";
            botonVolver.Size = new Size(121, 43);
            botonVolver.TabIndex = 10;
            botonVolver.Text = "Volver";
            botonVolver.UseVisualStyleBackColor = true;
            botonVolver.Click += botonVolver_Click_1;
            // 
            // labelseg
            // 
            labelseg.AutoSize = true;
            labelseg.Location = new Point(89, 680);
            labelseg.Name = "labelseg";
            labelseg.Size = new Size(157, 20);
            labelseg.TabIndex = 11;
            labelseg.Text = "Comprobar Seguridad";
            labelseg.Click += label5_Click;
            // 
            // ButtonRestart
            // 
            ButtonRestart.Location = new Point(125, 297);
            ButtonRestart.Name = "ButtonRestart";
            ButtonRestart.Size = new Size(121, 61);
            ButtonRestart.TabIndex = 12;
            ButtonRestart.Text = "Reiniciar";
            ButtonRestart.UseVisualStyleBackColor = true;
            ButtonRestart.Click += ButtonRestart_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // botocon
            // 
            botocon.Location = new Point(125, 440);
            botocon.Name = "botocon";
            botocon.Size = new Size(121, 59);
            botocon.TabIndex = 13;
            botocon.Text = "Conflicto";
            botocon.UseVisualStyleBackColor = true;
            botocon.Click += botocon_Click;
            // 
            // EspacioAereo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 757);
            Controls.Add(botocon);
            Controls.Add(button1);
            Controls.Add(ButtonRestart);
            Controls.Add(labelseg);
            Controls.Add(botonVolver);
            Controls.Add(ShowInfo);
            Controls.Add(Parar);
            Controls.Add(simularAut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botonMover);
            Controls.Add(panel1);
            Margin = new Padding(2, 4, 2, 4);
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
        private Button botonVolver;
        private Label labelseg;
        private Button ButtonRestart;
        private Button button1;
        private Button botocon;
    }
}