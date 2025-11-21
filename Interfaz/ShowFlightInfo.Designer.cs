namespace Interfaz
{
    partial class ShowFlightInfo
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Velocitybox = new TextBox();
            Xbox = new TextBox();
            Ybox = new TextBox();
            SuspendLayout();
            
            // button1
            
            button1.Location = new Point(344, 286);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            
            // label1
            
            label1.AutoSize = true;
            label1.Location = new Point(358, 75);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "Flight Info";
            
            // label2
            
            label2.AutoSize = true;
            label2.Location = new Point(174, 175);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Velocity";
            
            // label3
            
            label3.AutoSize = true;
            label3.Location = new Point(134, 234);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 3;
            label3.Text = "Current Position";
            
            // Velocitybox
            
            Velocitybox.Location = new Point(277, 168);
            Velocitybox.Name = "Velocitybox";
            Velocitybox.Size = new Size(125, 27);
            Velocitybox.TabIndex = 4;
            
            // Xbox
            
            Xbox.Location = new Point(277, 231);
            Xbox.Name = "Xbox";
            Xbox.Size = new Size(125, 27);
            Xbox.TabIndex = 5;
            
            // Ybox
            
            Ybox.Location = new Point(408, 231);
            Ybox.Name = "Ybox";
            Ybox.Size = new Size(125, 27);
            Ybox.TabIndex = 6;
            
            // ShowFlightInfo
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ybox);
            Controls.Add(Xbox);
            Controls.Add(Velocitybox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ShowFlightInfo";
            Text = "ShowFlightInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Velocitybox;
        private TextBox Xbox;
        private TextBox Ybox;
    }
}