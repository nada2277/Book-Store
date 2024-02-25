namespace BookStore.User.Forms
{
    partial class OrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 50, 3, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1307, 150);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 16F);
            label7.ForeColor = Color.FromArgb(85, 85, 85);
            label7.Location = new Point(1074, 54);
            label7.MaximumSize = new Size(220, 0);
            label7.MinimumSize = new Size(220, 0);
            label7.Name = "label7";
            label7.Size = new Size(220, 39);
            label7.TabIndex = 8;
            label7.Text = "Arrived On";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 16F);
            label6.ForeColor = Color.FromArgb(85, 85, 85);
            label6.Location = new Point(858, 54);
            label6.MaximumSize = new Size(200, 0);
            label6.MinimumSize = new Size(200, 0);
            label6.Name = "label6";
            label6.Size = new Size(200, 39);
            label6.TabIndex = 7;
            label6.Text = "TotalPrice";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 16F);
            label4.ForeColor = Color.FromArgb(85, 85, 85);
            label4.Location = new Point(632, 54);
            label4.MaximumSize = new Size(220, 0);
            label4.MinimumSize = new Size(220, 0);
            label4.Name = "label4";
            label4.Size = new Size(220, 39);
            label4.TabIndex = 6;
            label4.Text = "Ordered At";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 16F);
            label3.ForeColor = Color.FromArgb(85, 85, 85);
            label3.Location = new Point(426, 54);
            label3.MaximumSize = new Size(200, 0);
            label3.MinimumSize = new Size(200, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 39);
            label3.TabIndex = 5;
            label3.Text = "Status";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 16F);
            label2.ForeColor = Color.FromArgb(85, 85, 85);
            label2.Location = new Point(220, 54);
            label2.MaximumSize = new Size(200, 0);
            label2.MinimumSize = new Size(200, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 39);
            label2.TabIndex = 4;
            label2.Text = "Address";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = SystemColors.AppWorkspace;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(24, 128);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.MaximumSize = new Size(0, 3);
            label5.MinimumSize = new Size(1250, 3);
            label5.Name = "label5";
            label5.Size = new Size(1250, 3);
            label5.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Underline);
            label1.ForeColor = Color.FromArgb(85, 85, 85);
            label1.Location = new Point(24, 54);
            label1.MaximumSize = new Size(200, 0);
            label1.MinimumSize = new Size(200, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 39);
            label1.TabIndex = 0;
            label1.Text = "Number";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "OrderControl";
            Size = new Size(1307, 150);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
    }
}
