namespace Interfaz
{
    partial class Empresa
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
            PanelRegEmpresa = new Panel();
            label8 = new Label();
            regMail = new TextBox();
            label9 = new Label();
            Cancelar = new Button();
            registrar = new Button();
            regTel = new TextBox();
            label10 = new Label();
            regNom = new TextBox();
            label11 = new Label();
            PanelLogInEmpresa = new Panel();
            label7 = new Label();
            logInMail = new TextBox();
            label4 = new Label();
            anarAreg = new Button();
            logInBut = new Button();
            logInTel = new TextBox();
            label5 = new Label();
            logInNom = new TextBox();
            label6 = new Label();
            label1 = new Label();
            PanelRegEmpresa.SuspendLayout();
            PanelLogInEmpresa.SuspendLayout();
            SuspendLayout();
            // 
            // PanelRegEmpresa
            // 
            PanelRegEmpresa.Controls.Add(label8);
            PanelRegEmpresa.Controls.Add(regMail);
            PanelRegEmpresa.Controls.Add(label9);
            PanelRegEmpresa.Controls.Add(Cancelar);
            PanelRegEmpresa.Controls.Add(registrar);
            PanelRegEmpresa.Controls.Add(regTel);
            PanelRegEmpresa.Controls.Add(label10);
            PanelRegEmpresa.Controls.Add(regNom);
            PanelRegEmpresa.Controls.Add(label11);
            PanelRegEmpresa.Location = new Point(424, 116);
            PanelRegEmpresa.Name = "PanelRegEmpresa";
            PanelRegEmpresa.Size = new Size(327, 294);
            PanelRegEmpresa.TabIndex = 11;
            PanelRegEmpresa.Paint += RegEmpresa_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 198);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 8;
            label8.Text = "eMail";
            // 
            // regMail
            // 
            regMail.Location = new Point(155, 191);
            regMail.Name = "regMail";
            regMail.Size = new Size(125, 27);
            regMail.TabIndex = 7;
            regMail.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(69, 44);
            label9.Name = "label9";
            label9.Size = new Size(196, 25);
            label9.TabIndex = 6;
            label9.Text = "NUEVA EMPRESA";
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(171, 253);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(137, 29);
            Cancelar.TabIndex = 5;
            Cancelar.Text = "Cancelar Registro";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // registrar
            // 
            registrar.Location = new Point(31, 253);
            registrar.Name = "registrar";
            registrar.Size = new Size(124, 29);
            registrar.TabIndex = 4;
            registrar.Text = "Dar de alta";
            registrar.UseVisualStyleBackColor = true;
            registrar.Click += registrar_Click_1;
            // 
            // regTel
            // 
            regTel.Location = new Point(155, 140);
            regTel.Name = "regTel";
            regTel.Size = new Size(125, 27);
            regTel.TabIndex = 3;
            regTel.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(48, 140);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 2;
            label10.Text = "Teléfono:";
            // 
            // regNom
            // 
            regNom.Location = new Point(155, 93);
            regNom.Name = "regNom";
            regNom.Size = new Size(125, 27);
            regNom.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(56, 93);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 0;
            label11.Text = "Nombre:";
            // 
            // PanelLogInEmpresa
            // 
            PanelLogInEmpresa.Controls.Add(label7);
            PanelLogInEmpresa.Controls.Add(logInMail);
            PanelLogInEmpresa.Controls.Add(label4);
            PanelLogInEmpresa.Controls.Add(anarAreg);
            PanelLogInEmpresa.Controls.Add(logInBut);
            PanelLogInEmpresa.Controls.Add(logInTel);
            PanelLogInEmpresa.Controls.Add(label5);
            PanelLogInEmpresa.Controls.Add(logInNom);
            PanelLogInEmpresa.Controls.Add(label6);
            PanelLogInEmpresa.Location = new Point(50, 116);
            PanelLogInEmpresa.Name = "PanelLogInEmpresa";
            PanelLogInEmpresa.Size = new Size(327, 294);
            PanelLogInEmpresa.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 198);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 8;
            label7.Text = "eMail";
            // 
            // logInMail
            // 
            logInMail.Location = new Point(155, 191);
            logInMail.Name = "logInMail";
            logInMail.Size = new Size(125, 27);
            logInMail.TabIndex = 7;
            logInMail.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 44);
            label4.Name = "label4";
            label4.Size = new Size(290, 25);
            label4.TabIndex = 6;
            label4.Text = "ENTRAR DATOS EMPRESA";
            // 
            // anarAreg
            // 
            anarAreg.Location = new Point(161, 253);
            anarAreg.Name = "anarAreg";
            anarAreg.Size = new Size(153, 29);
            anarAreg.TabIndex = 5;
            anarAreg.Text = "Dar de Alta";
            anarAreg.UseVisualStyleBackColor = true;
            anarAreg.Click += anarAreg_Click_1;
            // 
            // logInBut
            // 
            logInBut.Location = new Point(17, 253);
            logInBut.Name = "logInBut";
            logInBut.Size = new Size(124, 29);
            logInBut.TabIndex = 4;
            logInBut.Text = "Entrar Datos";
            logInBut.UseVisualStyleBackColor = true;
            logInBut.Click += logInBut_Click;
            // 
            // logInTel
            // 
            logInTel.Location = new Point(155, 140);
            logInTel.Name = "logInTel";
            logInTel.Size = new Size(125, 27);
            logInTel.TabIndex = 3;
            logInTel.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 140);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 2;
            label5.Text = "Teléfono:";
            // 
            // logInNom
            // 
            logInNom.Location = new Point(155, 93);
            logInNom.Name = "logInNom";
            logInNom.Size = new Size(125, 27);
            logInNom.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 93);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 0;
            label6.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 9);
            label1.Name = "label1";
            label1.Size = new Size(640, 89);
            label1.TabIndex = 9;
            label1.Text = "DATOS DE LA EMPRESA";
            // 
            // Empresa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(PanelRegEmpresa);
            Controls.Add(PanelLogInEmpresa);
            Name = "Empresa";
            Text = "Empresa";
            PanelRegEmpresa.ResumeLayout(false);
            PanelRegEmpresa.PerformLayout();
            PanelLogInEmpresa.ResumeLayout(false);
            PanelLogInEmpresa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelRegEmpresa;
        private Label label8;
        private TextBox regMail;
        private Label label9;
        private Button Cancelar;
        private Button registrar;
        private TextBox regTel;
        private Label label10;
        private TextBox regNom;
        private Label label11;
        private Panel PanelLogInEmpresa;
        private Label label7;
        private TextBox logInMail;
        private Label label4;
        private Button anarAreg;
        private Button logInBut;
        private TextBox logInTel;
        private Label label5;
        private TextBox logInNom;
        private Label label6;
        private Label label1;
    }
}