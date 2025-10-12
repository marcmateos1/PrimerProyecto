namespace Interfaz
{
    partial class Principal
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
            botonDatos = new Button();
            botonDistancia = new Button();
            SuspendLayout();
            // 
            // botonDatos
            // 
            botonDatos.Location = new Point(12, 12);
            botonDatos.Name = "botonDatos";
            botonDatos.Size = new Size(170, 29);
            botonDatos.TabIndex = 0;
            botonDatos.Text = "Introducir datos";
            botonDatos.UseVisualStyleBackColor = true;
            botonDatos.Click += botonDatos_Click;
            // 
            // botonDistancia
            // 
            botonDistancia.Location = new Point(12, 47);
            botonDistancia.Name = "botonDistancia";
            botonDistancia.Size = new Size(170, 29);
            botonDistancia.TabIndex = 1;
            botonDistancia.Text = "Distancia de seguridad";
            botonDistancia.UseVisualStyleBackColor = true;
            botonDistancia.Click += botonDistancia_Click;
            // 
            // Interfaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonDistancia);
            Controls.Add(botonDatos);
            Name = "Interfaz";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button botonDatos;
        private Button botonDistancia;
    }
}
