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
            ButtonRestart = new Button();
            Conflicte = new Button();
            guardarBtn = new Button();
            Retroceder = new Button();
            labelUsuario2 = new Label();
            label5 = new Label();
            buttonCerrarSesión = new Button();
            reloj2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(482, 255);
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 500);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // botonMover
            // 
            botonMover.Anchor = AnchorStyles.None;
            botonMover.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonMover.Location = new Point(45, 226);
            botonMover.Margin = new Padding(2, 4, 2, 4);
            botonMover.Name = "botonMover";
            botonMover.Size = new Size(290, 76);
            botonMover.TabIndex = 1;
            botonMover.Text = "Mover Una Iteración";
            botonMover.UseVisualStyleBackColor = true;
            botonMover.Click += botonMover_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(451, 255);
            label1.Name = "label1";
            label1.Size = new Size(26, 25);
            label1.TabIndex = 3;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(482, 226);
            label2.Name = "label2";
            label2.Size = new Size(26, 25);
            label2.TabIndex = 4;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(440, 759);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 5;
            label3.Text = "500";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(970, 226);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 6;
            label4.Text = "500";
            // 
            // simularAut
            // 
            simularAut.Anchor = AnchorStyles.None;
            simularAut.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            simularAut.Location = new Point(45, 384);
            simularAut.Margin = new Padding(3, 4, 3, 4);
            simularAut.Name = "simularAut";
            simularAut.Size = new Size(290, 76);
            simularAut.TabIndex = 7;
            simularAut.Text = "Simular Automáticamente";
            simularAut.UseVisualStyleBackColor = true;
            simularAut.Click += simularAut_Click;
            // 
            // Parar
            // 
            Parar.Anchor = AnchorStyles.None;
            Parar.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Parar.Location = new Point(1139, 708);
            Parar.Margin = new Padding(3, 4, 3, 4);
            Parar.Name = "Parar";
            Parar.Size = new Size(153, 76);
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
            ShowInfo.Anchor = AnchorStyles.None;
            ShowInfo.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowInfo.Location = new Point(45, 544);
            ShowInfo.Margin = new Padding(3, 4, 3, 4);
            ShowInfo.Name = "ShowInfo";
            ShowInfo.Size = new Size(290, 76);
            ShowInfo.TabIndex = 9;
            ShowInfo.Text = "Muestra datos de los vuelos";
            ShowInfo.UseVisualStyleBackColor = true;
            ShowInfo.Click += ShowInfo_Click;
            // 
            // botonVolver
            // 
            botonVolver.Anchor = AnchorStyles.None;
            botonVolver.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonVolver.Location = new Point(766, 861);
            botonVolver.Name = "botonVolver";
            botonVolver.Size = new Size(121, 57);
            botonVolver.TabIndex = 10;
            botonVolver.Text = "Volver";
            botonVolver.UseVisualStyleBackColor = true;
            botonVolver.Click += botonVolver_Click_1;
            // 
            // ButtonRestart
            // 
            ButtonRestart.Anchor = AnchorStyles.None;
            ButtonRestart.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonRestart.Location = new Point(1139, 384);
            ButtonRestart.Name = "ButtonRestart";
            ButtonRestart.Size = new Size(153, 76);
            ButtonRestart.TabIndex = 12;
            ButtonRestart.Text = "Reiniciar";
            ButtonRestart.UseVisualStyleBackColor = true;
            ButtonRestart.Click += ButtonRestart_Click;
            // 
            // Conflicte
            // 
            Conflicte.Anchor = AnchorStyles.None;
            Conflicte.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Conflicte.Location = new Point(1139, 544);
            Conflicte.Margin = new Padding(3, 4, 3, 4);
            Conflicte.Name = "Conflicte";
            Conflicte.Size = new Size(153, 76);
            Conflicte.TabIndex = 13;
            Conflicte.Text = "Conflicto";
            Conflicte.UseVisualStyleBackColor = true;
            Conflicte.Click += Conflicte_Click;
            // 
            // guardarBtn
            // 
            guardarBtn.Anchor = AnchorStyles.None;
            guardarBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guardarBtn.Location = new Point(45, 708);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(290, 76);
            guardarBtn.TabIndex = 14;
            guardarBtn.Text = "Guardar Plan De Vuelo";
            guardarBtn.UseVisualStyleBackColor = true;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // Retroceder
            // 
            Retroceder.Anchor = AnchorStyles.None;
            Retroceder.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Retroceder.Location = new Point(1139, 231);
            Retroceder.Margin = new Padding(3, 4, 3, 4);
            Retroceder.Name = "Retroceder";
            Retroceder.Size = new Size(153, 76);
            Retroceder.TabIndex = 15;
            Retroceder.Text = "Retroceder";
            Retroceder.UseVisualStyleBackColor = true;
            Retroceder.Click += Retroceder_Click;
            // 
            // labelUsuario2
            // 
            labelUsuario2.AutoSize = true;
            labelUsuario2.Location = new Point(553, 22);
            labelUsuario2.Name = "labelUsuario2";
            labelUsuario2.Size = new Size(0, 20);
            labelUsuario2.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 28.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(507, 67);
            label5.Name = "label5";
            label5.Size = new Size(380, 53);
            label5.TabIndex = 17;
            label5.Text = "ESPACIO AÉREO";
            // 
            // buttonCerrarSesión
            // 
            buttonCerrarSesión.Anchor = AnchorStyles.None;
            buttonCerrarSesión.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCerrarSesión.Location = new Point(523, 861);
            buttonCerrarSesión.Name = "buttonCerrarSesión";
            buttonCerrarSesión.Size = new Size(158, 57);
            buttonCerrarSesión.TabIndex = 18;
            buttonCerrarSesión.Text = "Cerrar Sesión";
            buttonCerrarSesión.UseVisualStyleBackColor = true;
            buttonCerrarSesión.Click += buttonCerrarSesion_Click;
            // 
            // reloj2
            // 
            reloj2.Tick += reloj2_Tick;
            // 
            // EspacioAereo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 984);
            Controls.Add(buttonCerrarSesión);
            Controls.Add(label5);
            Controls.Add(botonMover);
            Controls.Add(simularAut);
            Controls.Add(guardarBtn);
            Controls.Add(labelUsuario2);
            Controls.Add(Retroceder);
            Controls.Add(Conflicte);
            Controls.Add(ButtonRestart);
            Controls.Add(botonVolver);
            Controls.Add(ShowInfo);
            Controls.Add(Parar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(2, 4, 2, 4);
            Name = "EspacioAereo";
            Text = "EspacioAereo";
            WindowState = FormWindowState.Maximized;
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
        private Label labelUsuario2;
        private Label label5;
        private Button buttonCerrarSesión;
        private System.Windows.Forms.Timer reloj2;
        private Button button1;
    }
}