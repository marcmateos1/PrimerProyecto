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
            Conflicte = new Button();
            guardarBtn = new Button();
            Retroceder = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(339, 38);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 375);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // botonMover
            // 
            botonMover.Location = new Point(109, 48);
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
            label1.Location = new Point(310, 38);
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
            label3.Location = new Point(287, 413);
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
            simularAut.Location = new Point(109, 106);
            simularAut.Name = "simularAut";
            simularAut.Size = new Size(106, 55);
            simularAut.TabIndex = 7;
            simularAut.Text = "Simular Automaticmente";
            simularAut.UseVisualStyleBackColor = true;
            simularAut.Click += simularAut_Click;
            // 
            // Parar
            // 
            Parar.Location = new Point(109, 166);
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
            ShowInfo.Location = new Point(109, 274);
            ShowInfo.Name = "ShowInfo";
            ShowInfo.Size = new Size(106, 51);
            ShowInfo.TabIndex = 9;
            ShowInfo.Text = "Muestra datos de los vuelos";
            ShowInfo.UseVisualStyleBackColor = true;
            ShowInfo.Click += ShowInfo_Click;
            // 
            // botonVolver
            // 
            botonVolver.Location = new Point(109, 387);
            botonVolver.Margin = new Padding(3, 2, 3, 2);
            botonVolver.Name = "botonVolver";
            botonVolver.Size = new Size(106, 32);
            botonVolver.TabIndex = 10;
            botonVolver.Text = "Volver";
            botonVolver.UseVisualStyleBackColor = true;
            botonVolver.Click += botonVolver_Click_1;
            // 
            // labelseg
            // 
            labelseg.AutoSize = true;
            labelseg.Location = new Point(78, 510);
            labelseg.Name = "labelseg";
            labelseg.Size = new Size(124, 15);
            labelseg.TabIndex = 11;
            labelseg.Text = "Comprobar Seguridad";
            labelseg.Click += label5_Click;
            // 
            // ButtonRestart
            // 
            ButtonRestart.Location = new Point(109, 223);
            ButtonRestart.Margin = new Padding(3, 2, 3, 2);
            ButtonRestart.Name = "ButtonRestart";
            ButtonRestart.Size = new Size(106, 46);
            ButtonRestart.TabIndex = 12;
            ButtonRestart.Text = "Reiniciar";
            ButtonRestart.UseVisualStyleBackColor = true;
            ButtonRestart.Click += ButtonRestart_Click;
            // 
            // Conflicte
            // 
            Conflicte.Location = new Point(109, 331);
            Conflicte.Name = "Conflicte";
            Conflicte.Size = new Size(106, 51);
            Conflicte.TabIndex = 13;
            Conflicte.Text = "Conflicte";
            Conflicte.UseVisualStyleBackColor = true;
            Conflicte.Click += Conflicte_Click;
            // 
            // guardarBtn
            // 
            guardarBtn.Location = new Point(867, 48);
            guardarBtn.Margin = new Padding(3, 2, 3, 2);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(106, 52);
            guardarBtn.TabIndex = 14;
            guardarBtn.Text = "Guardar Plan";
            guardarBtn.UseVisualStyleBackColor = true;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // Retroceder
            // 
            Retroceder.Location = new Point(867, 122);
            Retroceder.Name = "Retroceder";
            Retroceder.Size = new Size(106, 39);
            Retroceder.TabIndex = 15;
            Retroceder.Text = "Retroceder";
            Retroceder.UseVisualStyleBackColor = true;
            Retroceder.Click += Retroceder_Click;
            // 
            // EspacioAereo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 568);
            Controls.Add(Retroceder);
            Controls.Add(guardarBtn);
            Controls.Add(Conflicte);
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
        private Button botonVolver;
        private Label labelseg;
        private Button ButtonRestart;
        private Button Conflicte;
        private Button guardarBtn;
        private Button Retroceder;
    }
}