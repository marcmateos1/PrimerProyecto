namespace Interfaz
{
    partial class Seguridad
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
            botonDistancia = new Button();
            textDistancia = new TextBox();
            textTiempo = new TextBox();
            labelDistancia = new Label();
            labelTiempo = new Label();
            botonAtajo = new Button();
            SuspendLayout();
            // 
            // botonDistancia
            // 
            botonDistancia.Location = new Point(153, 133);
            botonDistancia.Name = "botonDistancia";
            botonDistancia.Size = new Size(94, 29);
            botonDistancia.TabIndex = 0;
            botonDistancia.Text = "Introducir datos";
            botonDistancia.UseVisualStyleBackColor = true;
            botonDistancia.Click += botonDistancia_Click;
            // 
            // textDistancia
            // 
            textDistancia.Location = new Point(39, 68);
            textDistancia.Name = "textDistancia";
            textDistancia.Size = new Size(125, 27);
            textDistancia.TabIndex = 2;
            // 
            // textTiempo
            // 
            textTiempo.Location = new Point(239, 68);
            textTiempo.Name = "textTiempo";
            textTiempo.Size = new Size(125, 27);
            textTiempo.TabIndex = 3;
            // 
            // labelDistancia
            // 
            labelDistancia.AutoSize = true;
            labelDistancia.Location = new Point(24, 45);
            labelDistancia.Name = "labelDistancia";
            labelDistancia.Size = new Size(190, 20);
            labelDistancia.TabIndex = 4;
            labelDistancia.Text = "Distancia de Seguridad (m)";
            // 
            // labelTiempo
            // 
            labelTiempo.AutoSize = true;
            labelTiempo.Location = new Point(239, 45);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(136, 20);
            labelTiempo.TabIndex = 5;
            labelTiempo.Text = "Tiempo de ciclo (s)";
            // 
            // botonAtajo
            // 
            botonAtajo.Location = new Point(153, 168);
            botonAtajo.Name = "botonAtajo";
            botonAtajo.Size = new Size(94, 29);
            botonAtajo.TabIndex = 6;
            botonAtajo.Text = "Atajo";
            botonAtajo.UseVisualStyleBackColor = true;
            botonAtajo.Click += botonAtajo_Click;
            // 
            // Seguridad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 220);
            Controls.Add(botonAtajo);
            Controls.Add(labelTiempo);
            Controls.Add(labelDistancia);
            Controls.Add(textTiempo);
            Controls.Add(textDistancia);
            Controls.Add(botonDistancia);
            Name = "Seguridad";
            Text = "Introduzca estos parametros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonDistancia;
        private TextBox textDistancia;
        private TextBox textTiempo;
        private Label labelDistancia;
        private Label labelTiempo;
        private Button botonAtajo;
    }
}