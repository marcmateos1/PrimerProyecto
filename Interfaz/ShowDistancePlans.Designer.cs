namespace Interfaz
{
    partial class ShowDistancePlans
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
            Taula2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Taula2).BeginInit();
            SuspendLayout();
            // 
            // Taula2
            // 
            Taula2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Taula2.Location = new Point(78, 43);
            Taula2.Name = "Taula2";
            Taula2.RowHeadersWidth = 51;
            Taula2.Size = new Size(533, 244);
            Taula2.TabIndex = 0;
            // 
            // ShowDistancePlans
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 360);
            Controls.Add(Taula2);
            Margin = new Padding(4);
            Name = "ShowDistancePlans";
            Text = "ShowDistancePlans";
            ((System.ComponentModel.ISupportInitialize)Taula2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Taula2;
    }
}