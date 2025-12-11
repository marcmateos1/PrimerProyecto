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
            Taula2.Anchor = AnchorStyles.None;
            Taula2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Taula2.Location = new Point(182, 48);
            Taula2.Name = "Taula2";
            Taula2.RowHeadersWidth = 51;
            Taula2.Size = new Size(474, 232);
            Taula2.TabIndex = 0;
            Taula2.CellContentClick += Taula2_CellContentClick;
            // 
            // ShowDistancePlans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 343);
            Controls.Add(Taula2);
            Margin = new Padding(4);
            Name = "ShowDistancePlans";
            Text = "ShowDistancePlans";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Taula2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Taula2;
    }
}