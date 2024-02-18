namespace BookStore.User.Forms
{
  partial class EmptyCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmptyCart));
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 508);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.FromArgb(39, 55, 77);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(449, 592);
            button2.Margin = new Padding(2, 2, 2, 24);
            button2.Name = "button2";
            button2.Size = new Size(249, 65);
            button2.TabIndex = 13;
            button2.Text = "Shop our products";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(39, 55, 77);
            label1.Location = new Point(408, 517);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(343, 48);
            label1.TabIndex = 0;
            label1.Text = "Your cart is empty";
            // 
            // EmptyCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1108, 708);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "EmptyCart";
            Text = "EmptyCart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
    private Label label1;
    private Button button2;
  }
}