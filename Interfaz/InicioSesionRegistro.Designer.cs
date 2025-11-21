namespace Interfaz
{
    partial class InicioSesionRegistro
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
            panelRegistro = new Panel();
            buttonCancelarRegistro = new Button();
            buttonCrearUsuario = new Button();
            NuevaContraseña = new TextBox();
            textNuevoUsuario = new TextBox();
            labelNuevaContraseña = new Label();
            labelNuevoUsuario = new Label();
            panelInicioSesion = new Panel();
            buttonRegistrarse = new Button();
            buttonIniciarSesion = new Button();
            textContraseña = new TextBox();
            labelContraseña = new Label();
            textUsuario = new TextBox();
            labelInicioSesion = new Label();
            panelRegistro.SuspendLayout();
            panelInicioSesion.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegistro
            // 
            panelRegistro.Controls.Add(buttonCancelarRegistro);
            panelRegistro.Controls.Add(buttonCrearUsuario);
            panelRegistro.Controls.Add(NuevaContraseña);
            panelRegistro.Controls.Add(textNuevoUsuario);
            panelRegistro.Controls.Add(labelNuevaContraseña);
            panelRegistro.Controls.Add(labelNuevoUsuario);
            panelRegistro.Location = new Point(424, 31);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(345, 374);
            panelRegistro.TabIndex = 0;
            panelRegistro.Visible = false;
            // 
            // buttonCancelarRegistro
            // 
            buttonCancelarRegistro.Location = new Point(176, 253);
            buttonCancelarRegistro.Name = "buttonCancelarRegistro";
            buttonCancelarRegistro.Size = new Size(139, 29);
            buttonCancelarRegistro.TabIndex = 5;
            buttonCancelarRegistro.Text = "Cancelar Registro";
            buttonCancelarRegistro.UseVisualStyleBackColor = true;
            buttonCancelarRegistro.Click += buttonCancelarRegistro_Click;
            // 
            // buttonCrearUsuario
            // 
            buttonCrearUsuario.Location = new Point(30, 253);
            buttonCrearUsuario.Name = "buttonCrearUsuario";
            buttonCrearUsuario.Size = new Size(136, 29);
            buttonCrearUsuario.TabIndex = 4;
            buttonCrearUsuario.Text = "Crear Usuario";
            buttonCrearUsuario.UseVisualStyleBackColor = true;
            buttonCrearUsuario.Click += buttonCrearUsuario_Click;
            // 
            // NuevaContraseña
            // 
            NuevaContraseña.Location = new Point(183, 178);
            NuevaContraseña.Name = "NuevaContraseña";
            NuevaContraseña.Size = new Size(125, 27);
            NuevaContraseña.TabIndex = 3;
            NuevaContraseña.UseSystemPasswordChar = true;
            // 
            // textNuevoUsuario
            // 
            textNuevoUsuario.Location = new Point(183, 107);
            textNuevoUsuario.Name = "textNuevoUsuario";
            textNuevoUsuario.Size = new Size(125, 27);
            textNuevoUsuario.TabIndex = 2;
            // 
            // labelNuevaContraseña
            // 
            labelNuevaContraseña.AutoSize = true;
            labelNuevaContraseña.Location = new Point(34, 185);
            labelNuevaContraseña.Name = "labelNuevaContraseña";
            labelNuevaContraseña.Size = new Size(132, 20);
            labelNuevaContraseña.TabIndex = 1;
            labelNuevaContraseña.Text = "Nueva Contraseña:";
            // 
            // labelNuevoUsuario
            // 
            labelNuevoUsuario.AutoSize = true;
            labelNuevoUsuario.Location = new Point(43, 110);
            labelNuevoUsuario.Name = "labelNuevoUsuario";
            labelNuevoUsuario.Size = new Size(109, 20);
            labelNuevoUsuario.TabIndex = 0;
            labelNuevoUsuario.Text = "Nuevo Usuario:";
            // 
            // panelInicioSesion
            // 
            panelInicioSesion.Controls.Add(buttonRegistrarse);
            panelInicioSesion.Controls.Add(buttonIniciarSesion);
            panelInicioSesion.Controls.Add(textContraseña);
            panelInicioSesion.Controls.Add(labelContraseña);
            panelInicioSesion.Controls.Add(textUsuario);
            panelInicioSesion.Controls.Add(labelInicioSesion);
            panelInicioSesion.Location = new Point(62, 31);
            panelInicioSesion.Name = "panelInicioSesion";
            panelInicioSesion.Size = new Size(327, 374);
            panelInicioSesion.TabIndex = 1;
            // 
            // buttonRegistrarse
            // 
            buttonRegistrarse.Location = new Point(171, 253);
            buttonRegistrarse.Name = "buttonRegistrarse";
            buttonRegistrarse.Size = new Size(94, 29);
            buttonRegistrarse.TabIndex = 5;
            buttonRegistrarse.Text = "Registrarse";
            buttonRegistrarse.UseVisualStyleBackColor = true;
            buttonRegistrarse.Click += buttonRegistrarse_Click;
            // 
            // buttonIniciarSesion
            // 
            buttonIniciarSesion.Location = new Point(31, 253);
            buttonIniciarSesion.Name = "buttonIniciarSesion";
            buttonIniciarSesion.Size = new Size(124, 29);
            buttonIniciarSesion.TabIndex = 4;
            buttonIniciarSesion.Text = "Iniciar Sesión";
            buttonIniciarSesion.UseVisualStyleBackColor = true;
            buttonIniciarSesion.Click += buttonIniciarSesion_Click;
            // 
            // textContraseña
            // 
            textContraseña.Location = new Point(155, 178);
            textContraseña.Name = "textContraseña";
            textContraseña.Size = new Size(125, 27);
            textContraseña.TabIndex = 3;
            textContraseña.UseSystemPasswordChar = true;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(43, 181);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(86, 20);
            labelContraseña.TabIndex = 2;
            labelContraseña.Text = "Contraseña:";
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(155, 110);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(125, 27);
            textUsuario.TabIndex = 1;
            textUsuario.TextChanged += textInicioSesion_TextChanged;
            // 
            // labelInicioSesion
            // 
            labelInicioSesion.AutoSize = true;
            labelInicioSesion.Location = new Point(56, 113);
            labelInicioSesion.Name = "labelInicioSesion";
            labelInicioSesion.Size = new Size(62, 20);
            labelInicioSesion.TabIndex = 0;
            labelInicioSesion.Text = "Usuario:";
            // 
            // InicioSesionRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelInicioSesion);
            Controls.Add(panelRegistro);
            Name = "InicioSesionRegistro";
            Text = "Form1";
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            panelInicioSesion.ResumeLayout(false);
            panelInicioSesion.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel panelRegistro;
        private Panel panelInicioSesion;
        private Label labelInicioSesion;
        private TextBox textContraseña;
        private Label labelContraseña;
        private TextBox textUsuario;
        private Button buttonRegistrarse;
        private Button buttonIniciarSesion;
        private Button buttonCancelarRegistro;
        private Button buttonCrearUsuario;
        private TextBox NuevaContraseña;
        private TextBox textNuevoUsuario;
        private Label labelNuevaContraseña;
        private Label labelNuevoUsuario;
    }
}