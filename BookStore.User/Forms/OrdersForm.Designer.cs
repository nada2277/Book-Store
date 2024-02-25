namespace BookStore.User.Forms
{
  partial class OrdersForm
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
            panel1 = new Panel();
            label5 = new Label();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(120, 0);
            panel1.MaximumSize = new Size(1346, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(1346, 131);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = SystemColors.AppWorkspace;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(44, 94);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.MaximumSize = new Size(0, 3);
            label5.MinimumSize = new Size(1250, 3);
            label5.Name = "label5";
            label5.Size = new Size(1250, 3);
            label5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label7.Location = new Point(1085, 43);
            label7.MaximumSize = new Size(200, 0);
            label7.MinimumSize = new Size(200, 0);
            label7.Name = "label7";
            label7.Size = new Size(200, 40);
            label7.TabIndex = 15;
            label7.Text = "Arrived On";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label3.Location = new Point(435, 43);
            label3.MaximumSize = new Size(200, 0);
            label3.MinimumSize = new Size(200, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 40);
            label3.TabIndex = 12;
            label3.Text = "Status";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label6.Location = new Point(867, 43);
            label6.MaximumSize = new Size(200, 0);
            label6.MinimumSize = new Size(200, 0);
            label6.Name = "label6";
            label6.Size = new Size(200, 40);
            label6.TabIndex = 14;
            label6.Text = "TotalPrice";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(23, 43);
            label1.MaximumSize = new Size(200, 0);
            label1.MinimumSize = new Size(200, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 40);
            label1.TabIndex = 9;
            label1.Text = "Number";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label4.Location = new Point(622, 43);
            label4.MaximumSize = new Size(200, 0);
            label4.MinimumSize = new Size(220, 0);
            label4.Name = "label4";
            label4.Size = new Size(220, 40);
            label4.TabIndex = 13;
            label4.Text = "Ordered At";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label2.Location = new Point(229, 43);
            label2.MaximumSize = new Size(200, 0);
            label2.MinimumSize = new Size(200, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 40);
            label2.TabIndex = 11;
            label2.Text = "Address";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(120, 131);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1346, 319);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1466, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "OrdersForm";
            Padding = new Padding(120, 0, 0, 0);
            Text = "Orders";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label2;
    }
}