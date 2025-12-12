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
            registrar = new Button();
            regTel = new TextBox();
            label10 = new Label();
            regNom = new TextBox();
            label11 = new Label();
            label1 = new Label();
            bttnCancelarDatosEmpresa = new Button();
            PanelRegEmpresa.SuspendLayout();
            SuspendLayout();
            // 
            // PanelRegEmpresa
            // 
            PanelRegEmpresa.Anchor = AnchorStyles.None;
            PanelRegEmpresa.Controls.Add(label8);
            PanelRegEmpresa.Controls.Add(regMail);
            PanelRegEmpresa.Controls.Add(label9);
            PanelRegEmpresa.Controls.Add(registrar);
            PanelRegEmpresa.Controls.Add(regTel);
            PanelRegEmpresa.Controls.Add(label10);
            PanelRegEmpresa.Controls.Add(regNom);
            PanelRegEmpresa.Controls.Add(label11);
            PanelRegEmpresa.Location = new Point(301, 259);
            PanelRegEmpresa.Name = "PanelRegEmpresa";
            PanelRegEmpresa.Size = new Size(328, 327);
            PanelRegEmpresa.TabIndex = 11;
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
            // registrar
            // 
            registrar.Location = new Point(102, 253);
            registrar.Name = "registrar";
            registrar.Size = new Size(124, 29);
            registrar.TabIndex = 4;
            registrar.Text = "Dar de alta";
            registrar.UseVisualStyleBackColor = true;
            // 
            // regTel
            // 
            regTel.Location = new Point(155, 140);
            regTel.Name = "regTel";
            regTel.Size = new Size(125, 27);
            regTel.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(56, 140);
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
            label11.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(59, 93);
            label11.Name = "label11";
            label11.Size = new Size(63, 19);
            label11.TabIndex = 0;
            label11.Text = "Nombre:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 87);
            label1.Name = "label1";
            label1.Size = new Size(638, 87);
            label1.TabIndex = 9;
            label1.Text = "DATOS DE LA EMPRESA";
            // 
            // bttnCancelarDatosEmpresa
            // 
            bttnCancelarDatosEmpresa.Anchor = AnchorStyles.None;
            bttnCancelarDatosEmpresa.Location = new Point(391, 651);
            bttnCancelarDatosEmpresa.Name = "bttnCancelarDatosEmpresa";
            bttnCancelarDatosEmpresa.Size = new Size(146, 52);
            bttnCancelarDatosEmpresa.TabIndex = 12;
            bttnCancelarDatosEmpresa.Text = "Cancelar";
            bttnCancelarDatosEmpresa.UseVisualStyleBackColor = true;
            bttnCancelarDatosEmpresa.Click += bttnCancelarDatosEmpresa_Click;
            // 
            // Empresa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 762);
            Controls.Add(bttnCancelarDatosEmpresa);
            Controls.Add(label1);
            Controls.Add(PanelRegEmpresa);
            Name = "Empresa";
            Text = "Empresa";
            WindowState = FormWindowState.Maximized;
            PanelRegEmpresa.ResumeLayout(false);
            PanelRegEmpresa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelRegEmpresa;
        private Label label8;
        private TextBox regMail;
        private Label label9;
        private Button registrar;
        private TextBox regTel;
        private Label label10;
        private TextBox regNom;
        private Label label11;
        private Label label1;
        private Button bttnCancelarDatosEmpresa;
    }
}