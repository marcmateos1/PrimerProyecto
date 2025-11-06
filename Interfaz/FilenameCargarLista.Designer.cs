namespace Interfaz
{
    partial class FilenameCargarLista
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
            fileNameBox = new TextBox();
            fileNameLabel = new Label();
            cargarBtn = new Button();
            SuspendLayout();
            // 
            // fileNameBox
            // 
            fileNameBox.Location = new Point(46, 76);
            fileNameBox.Name = "fileNameBox";
            fileNameBox.Size = new Size(125, 27);
            fileNameBox.TabIndex = 0;
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new Point(32, 35);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(164, 20);
            fileNameLabel.TabIndex = 1;
            fileNameLabel.Text = "Como se llama su lista?";
            // 
            // cargarBtn
            // 
            cargarBtn.Location = new Point(60, 109);
            cargarBtn.Name = "cargarBtn";
            cargarBtn.Size = new Size(94, 29);
            cargarBtn.TabIndex = 3;
            cargarBtn.Text = "Cargar";
            cargarBtn.UseVisualStyleBackColor = true;
            cargarBtn.Click += cargarBtn_Click;
            // 
            // FilenameCargarLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 215);
            Controls.Add(cargarBtn);
            Controls.Add(fileNameLabel);
            Controls.Add(fileNameBox);
            Name = "FilenameCargarLista";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fileNameBox;
        private Label fileNameLabel;
        private Button cargarBtn;
    }
}