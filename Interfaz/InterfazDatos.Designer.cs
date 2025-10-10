namespace InterfazDatos
{
    partial class InterfazDatos
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(33, 21);
            label1.Name = "label1";
            label1.Size = new Size(96, 22);
            label1.TabIndex = 0;
            label1.Text = "Identificador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(33, 197);
            label2.Name = "label2";
            label2.Size = new Size(77, 22);
            label2.TabIndex = 1;
            label2.Text = "Velocidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(256, 21);
            label3.Name = "label3";
            label3.Size = new Size(63, 22);
            label3.TabIndex = 2;
            label3.Text = "X inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(256, 197);
            label4.Name = "label4";
            label4.Size = new Size(62, 22);
            label4.TabIndex = 3;
            label4.Text = "Y inicial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(482, 197);
            label5.Name = "label5";
            label5.Size = new Size(52, 22);
            label5.TabIndex = 4;
            label5.Text = "Y final";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(501, 21);
            label6.Name = "label6";
            label6.Size = new Size(53, 22);
            label6.TabIndex = 5;
            label6.Text = "X final";
            // 
            // TIdentificador
            // 
            TIdentificador.Location = new Point(33, 69);
            TIdentificador.Name = "TIdentificador";
            TIdentificador.Size = new Size(125, 27);
            TIdentificador.TabIndex = 6;
            // 
            // TVelocidad
            // 
            TVelocidad.Location = new Point(33, 318);
            TVelocidad.Name = "TVelocidad";
            TVelocidad.Size = new Size(125, 27);
            TVelocidad.TabIndex = 7;
            // 
            // TX0
            // 
            TX0.Location = new Point(256, 69);
            TX0.Name = "TX0";
            TX0.Size = new Size(125, 27);
            TX0.TabIndex = 8;
            // 
            // TY0
            // 
            TY0.Location = new Point(256, 318);
            TY0.Name = "TY0";
            TY0.Size = new Size(125, 27);
            TY0.TabIndex = 9;
            // 
            // TXF
            // 
            TXF.Location = new Point(482, 69);
            TXF.Name = "TXF";
            TXF.Size = new Size(125, 27);
            TXF.TabIndex = 10;
            // 
            // TYF
            // 
            TYF.Location = new Point(482, 318);
            TYF.Name = "TYF";
            TYF.Size = new Size(125, 27);
            TYF.TabIndex = 11;
            // 
            // BCompilar
            // 
            BCompilar.Location = new Point(635, 190);
            BCompilar.Name = "BCompilar";
            BCompilar.Size = new Size(94, 29);
            BCompilar.TabIndex = 12;
            BCompilar.Text = "Compilar datos";
            BCompilar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Form1";
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
    }
}
