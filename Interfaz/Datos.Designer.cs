namespace InterfazDatos
{
    partial class Datos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TIdentificador = new TextBox();
            TVelocidad = new TextBox();
            TX0 = new TextBox();
            TY0 = new TextBox();
            TXF = new TextBox();
            TYF = new TextBox();
            BCompilar = new Button();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            TIdentificador2 = new TextBox();
            TXF2 = new TextBox();
            TX02 = new TextBox();
            TVelocidad2 = new TextBox();
            TYF2 = new TextBox();
            TY02 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            atajo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(69, 126);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 0;
            label1.Text = "Identificador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(222, 126);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 1;
            label2.Text = "Velocidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(83, 180);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 2;
            label3.Text = "X inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(83, 237);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 3;
            label4.Text = "Y inicial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(222, 237);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 4;
            label5.Text = "Y final";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(222, 180);
            label6.Name = "label6";
            label6.Size = new Size(42, 17);
            label6.TabIndex = 5;
            label6.Text = "X final";
            // 
            // TIdentificador
            // 
            TIdentificador.Location = new Point(54, 145);
            TIdentificador.Margin = new Padding(3, 2, 3, 2);
            TIdentificador.Name = "TIdentificador";
            TIdentificador.Size = new Size(110, 23);
            TIdentificador.TabIndex = 6;
            // 
            // TVelocidad
            // 
            TVelocidad.Location = new Point(194, 145);
            TVelocidad.Margin = new Padding(3, 2, 3, 2);
            TVelocidad.Name = "TVelocidad";
            TVelocidad.Size = new Size(110, 23);
            TVelocidad.TabIndex = 7;
            // 
            // TX0
            // 
            TX0.Location = new Point(54, 199);
            TX0.Margin = new Padding(3, 2, 3, 2);
            TX0.Name = "TX0";
            TX0.Size = new Size(110, 23);
            TX0.TabIndex = 8;
            // 
            // TY0
            // 
            TY0.Location = new Point(54, 256);
            TY0.Margin = new Padding(3, 2, 3, 2);
            TY0.Name = "TY0";
            TY0.Size = new Size(110, 23);
            TY0.TabIndex = 9;
            // 
            // TXF
            // 
            TXF.Location = new Point(194, 199);
            TXF.Margin = new Padding(3, 2, 3, 2);
            TXF.Name = "TXF";
            TXF.Size = new Size(110, 23);
            TXF.TabIndex = 10;
            // 
            // TYF
            // 
            TYF.Location = new Point(194, 256);
            TYF.Margin = new Padding(3, 2, 3, 2);
            TYF.Name = "TYF";
            TYF.Size = new Size(110, 23);
            TYF.TabIndex = 11;
            // 
            // BCompilar
            // 
            BCompilar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BCompilar.Location = new Point(281, 331);
            BCompilar.Margin = new Padding(3, 2, 3, 2);
            BCompilar.Name = "BCompilar";
            BCompilar.Size = new Size(125, 50);
            BCompilar.TabIndex = 12;
            BCompilar.Text = "Compilar datos";
            BCompilar.UseVisualStyleBackColor = true;
            BCompilar.Click += BCompilar_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(121, 21);
            label8.Name = "label8";
            label8.Size = new Size(479, 29);
            label8.TabIndex = 14;
            label8.Text = "Introuce los datos de los dos vuelos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(136, 82);
            label7.Name = "label7";
            label7.Size = new Size(82, 23);
            label7.TabIndex = 15;
            label7.Text = "Vuelo 1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(473, 82);
            label9.Name = "label9";
            label9.Size = new Size(83, 23);
            label9.TabIndex = 16;
            label9.Text = "Vuelo 2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Location = new Point(429, 126);
            label10.Name = "label10";
            label10.Size = new Size(76, 17);
            label10.TabIndex = 17;
            label10.Text = "Identificador";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Location = new Point(558, 126);
            label11.Name = "label11";
            label11.Size = new Size(60, 17);
            label11.TabIndex = 18;
            label11.Text = "Velocidad";
            // 
            // TIdentificador2
            // 
            TIdentificador2.Location = new Point(409, 145);
            TIdentificador2.Margin = new Padding(3, 2, 3, 2);
            TIdentificador2.Name = "TIdentificador2";
            TIdentificador2.Size = new Size(110, 23);
            TIdentificador2.TabIndex = 19;
            // 
            // TXF2
            // 
            TXF2.Location = new Point(534, 199);
            TXF2.Margin = new Padding(3, 2, 3, 2);
            TXF2.Name = "TXF2";
            TXF2.Size = new Size(110, 23);
            TXF2.TabIndex = 20;
            // 
            // TX02
            // 
            TX02.Location = new Point(409, 199);
            TX02.Margin = new Padding(3, 2, 3, 2);
            TX02.Name = "TX02";
            TX02.Size = new Size(110, 23);
            TX02.TabIndex = 21;
            // 
            // TVelocidad2
            // 
            TVelocidad2.Location = new Point(534, 145);
            TVelocidad2.Margin = new Padding(3, 2, 3, 2);
            TVelocidad2.Name = "TVelocidad2";
            TVelocidad2.Size = new Size(110, 23);
            TVelocidad2.TabIndex = 22;
            // 
            // TYF2
            // 
            TYF2.Location = new Point(534, 253);
            TYF2.Margin = new Padding(3, 2, 3, 2);
            TYF2.Name = "TYF2";
            TYF2.Size = new Size(110, 23);
            TYF2.TabIndex = 23;
            // 
            // TY02
            // 
            TY02.Location = new Point(409, 253);
            TY02.Margin = new Padding(3, 2, 3, 2);
            TY02.Name = "TY02";
            TY02.Size = new Size(110, 23);
            TY02.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Location = new Point(567, 180);
            label12.Name = "label12";
            label12.Size = new Size(42, 17);
            label12.TabIndex = 25;
            label12.Text = "X final";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Location = new Point(438, 180);
            label13.Name = "label13";
            label13.Size = new Size(50, 17);
            label13.TabIndex = 26;
            label13.Text = "X inicial";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Location = new Point(438, 234);
            label14.Name = "label14";
            label14.Size = new Size(50, 17);
            label14.TabIndex = 27;
            label14.Text = "Y inicial";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Location = new Point(558, 234);
            label15.Name = "label15";
            label15.Size = new Size(42, 17);
            label15.TabIndex = 28;
            label15.Text = "Y final";
            // 
            // atajo
            // 
            atajo.Location = new Point(302, 396);
            atajo.Name = "atajo";
            atajo.Size = new Size(75, 23);
            atajo.TabIndex = 29;
            atajo.Text = "Atajo";
            atajo.UseVisualStyleBackColor = true;
            atajo.Click += atajo_Click;
            // 
            // Datos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 452);
            Controls.Add(atajo);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(TY02);
            Controls.Add(TYF2);
            Controls.Add(TVelocidad2);
            Controls.Add(TX02);
            Controls.Add(TXF2);
            Controls.Add(TIdentificador2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(BCompilar);
            Controls.Add(TYF);
            Controls.Add(TXF);
            Controls.Add(TY0);
            Controls.Add(TX0);
            Controls.Add(TVelocidad);
            Controls.Add(TIdentificador);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Datos";
            Text = "Introduzca los Datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TIdentificador;
        private TextBox TVelocidad;
        private TextBox TX0;
        private TextBox TY0;
        private TextBox TXF;
        private TextBox TYF;
        private Button BCompilar;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox TIdentificador2;
        private TextBox TXF2;
        private TextBox TX02;
        private TextBox TVelocidad2;
        private TextBox TYF2;
        private TextBox TY02;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button atajo;
    }
}
