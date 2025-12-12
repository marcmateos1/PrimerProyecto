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
            bttnEmpresasRegistradas = new Button();
            panel1 = new Panel();
            buttEliminarEmp = new Button();
            label2 = new Label();
            elimcorreu = new TextBox();
            label3 = new Label();
            elimtelf = new TextBox();
            label4 = new Label();
            elimnom = new TextBox();
            label5 = new Label();
            PanelRegEmpresa.SuspendLayout();
            panel1.SuspendLayout();
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
            PanelRegEmpresa.Location = new Point(130, 255);
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
            registrar.Click += registrar_Click_1;
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
            bttnCancelarDatosEmpresa.Location = new Point(270, 656);
            bttnCancelarDatosEmpresa.Name = "bttnCancelarDatosEmpresa";
            bttnCancelarDatosEmpresa.Size = new Size(146, 52);
            bttnCancelarDatosEmpresa.TabIndex = 12;
            bttnCancelarDatosEmpresa.Text = "Cancelar";
            bttnCancelarDatosEmpresa.UseVisualStyleBackColor = true;
            bttnCancelarDatosEmpresa.Click += bttnCancelarDatosEmpresa_Click;
            // 
            // bttnEmpresasRegistradas
            // 
            bttnEmpresasRegistradas.Anchor = AnchorStyles.None;
            bttnEmpresasRegistradas.Location = new Point(483, 656);
            bttnEmpresasRegistradas.Name = "bttnEmpresasRegistradas";
            bttnEmpresasRegistradas.Size = new Size(184, 52);
            bttnEmpresasRegistradas.TabIndex = 13;
            bttnEmpresasRegistradas.Text = "Empresas Registradas";
            bttnEmpresasRegistradas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(buttEliminarEmp);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(elimcorreu);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(elimtelf);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(elimnom);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(514, 255);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 327);
            panel1.TabIndex = 12;
            // 
            // buttEliminarEmp
            // 
            buttEliminarEmp.Location = new Point(122, 268);
            buttEliminarEmp.Name = "buttEliminarEmp";
            buttEliminarEmp.Size = new Size(94, 29);
            buttEliminarEmp.TabIndex = 9;
            buttEliminarEmp.Text = "Eliminar";
            buttEliminarEmp.UseVisualStyleBackColor = true;
            buttEliminarEmp.Click += buttEliminarEmp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 198);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 8;
            label2.Text = "eMail";
            // 
            // elimcorreu
            // 
            elimcorreu.Location = new Point(155, 191);
            elimcorreu.Name = "elimcorreu";
            elimcorreu.Size = new Size(125, 27);
            elimcorreu.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 44);
            label3.Name = "label3";
            label3.Size = new Size(222, 25);
            label3.TabIndex = 6;
            label3.Text = "ELIMINAR EMPRESA";
            // 
            // elimtelf
            // 
            elimtelf.Location = new Point(155, 140);
            elimtelf.Name = "elimtelf";
            elimtelf.Size = new Size(125, 27);
            elimtelf.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 140);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 2;
            label4.Text = "Teléfono:";
            // 
            // elimnom
            // 
            elimnom.Location = new Point(155, 93);
            elimnom.Name = "elimnom";
            elimnom.Size = new Size(125, 27);
            elimnom.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 93);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 0;
            label5.Text = "Nombre:";
            // 
            // Empresa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 762);
            Controls.Add(panel1);
            Controls.Add(bttnEmpresasRegistradas);
            Controls.Add(bttnCancelarDatosEmpresa);
            Controls.Add(label1);
            Controls.Add(PanelRegEmpresa);
            Name = "Empresa";
            Text = "Empresa";
            WindowState = FormWindowState.Maximized;
            PanelRegEmpresa.ResumeLayout(false);
            PanelRegEmpresa.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button bttnEmpresasRegistradas;
        private Panel panel1;
        private Label label2;
        private TextBox elimcorreu;
        private Label label3;
        private TextBox elimtelf;
        private Label label4;
        private TextBox elimnom;
        private Label label5;
        private Button buttEliminarEmp;
    }
}