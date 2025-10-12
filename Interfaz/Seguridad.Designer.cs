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
            SuspendLayout();
            // 
            // botonDistancia
            // 
            botonDistancia.Location = new Point(310, 123);
            botonDistancia.Margin = new Padding(3, 2, 3, 2);
            botonDistancia.Name = "botonDistancia";
            botonDistancia.Size = new Size(82, 22);
            botonDistancia.TabIndex = 0;
            botonDistancia.Text = "Introducir datos";
            botonDistancia.UseVisualStyleBackColor = true;
            botonDistancia.Click += botonDistancia_Click;
            // 
            // textDistancia
            // 
            textDistancia.Location = new Point(100, 52);
            textDistancia.Margin = new Padding(3, 2, 3, 2);
            textDistancia.Name = "textDistancia";
            textDistancia.Size = new Size(110, 23);
            textDistancia.TabIndex = 2;
            // 
            // textTiempo
            // 
            textTiempo.Location = new Point(440, 52);
            textTiempo.Margin = new Padding(3, 2, 3, 2);
            textTiempo.Name = "textTiempo";
            textTiempo.Size = new Size(110, 23);
            textTiempo.TabIndex = 3;
            // 
            // labelDistancia
            // 
            labelDistancia.AutoSize = true;
            labelDistancia.Location = new Point(100, 34);
            labelDistancia.Name = "labelDistancia";
            labelDistancia.Size = new Size(149, 15);
            labelDistancia.TabIndex = 4;
            labelDistancia.Text = "Distancia de Seguridad (m)";
            // 
            // labelTiempo
            // 
            labelTiempo.AutoSize = true;
            labelTiempo.Location = new Point(440, 34);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(107, 15);
            labelTiempo.TabIndex = 5;
            labelTiempo.Text = "Tiempo de ciclo (s)";
            // 
            // Seguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(labelTiempo);
            Controls.Add(labelDistancia);
            Controls.Add(textTiempo);
            Controls.Add(textDistancia);
            Controls.Add(botonDistancia);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}