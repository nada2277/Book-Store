namespace BookStore.User.Forms
{
  partial class CartItemControler
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartItemControler));
      panel1 = new Panel();
      label2 = new Label();
      button4 = new Button();
      button3 = new Button();
      quantity = new Button();
      button1 = new Button();
      label5 = new Label();
      label1 = new Label();
      pictureBox1 = new PictureBox();
      panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // panel1
      // 
      panel1.AutoSize = true;
      panel1.Controls.Add(label2);
      panel1.Controls.Add(button4);
      panel1.Controls.Add(button3);
      panel1.Controls.Add(quantity);
      panel1.Controls.Add(button1);
      panel1.Controls.Add(label5);
      panel1.Controls.Add(label1);
      panel1.Controls.Add(pictureBox1);
      panel1.Dock = DockStyle.Fill;
      panel1.Location = new Point(0, 0);
      panel1.Margin = new Padding(2);
      panel1.Name = "panel1";
      panel1.Size = new Size(1226, 259);
      panel1.TabIndex = 0;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 14F);
      label2.Location = new Point(1055, 105);
      label2.Margin = new Padding(2, 0, 2, 0);
      label2.MinimumSize = new Size(200, 0);
      label2.Name = "label2";
      label2.Size = new Size(200, 38);
      label2.TabIndex = 7;
      label2.Text = "Price";
      // 
      // button4
      // 
      button4.Cursor = Cursors.Hand;
      button4.FlatStyle = FlatStyle.Flat;
      button4.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
      button4.Location = new Point(895, 91);
      button4.Margin = new Padding(2);
      button4.Name = "button4";
      button4.Size = new Size(60, 62);
      button4.TabIndex = 6;
      button4.Text = "X";
      button4.UseVisualStyleBackColor = true;
      button4.Click += button4_Click;
      // 
      // button3
      // 
      button3.Cursor = Cursors.Hand;
      button3.FlatStyle = FlatStyle.Flat;
      button3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
      button3.Location = new Point(745, 91);
      button3.Margin = new Padding(2);
      button3.Name = "button3";
      button3.Size = new Size(60, 62);
      button3.TabIndex = 5;
      button3.Text = "-";
      button3.UseVisualStyleBackColor = true;
      button3.Click += button3_Click;
      // 
      // quantity
      // 
      quantity.Enabled = false;
      quantity.FlatStyle = FlatStyle.Flat;
      quantity.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
      quantity.Location = new Point(679, 91);
      quantity.Margin = new Padding(2);
      quantity.Name = "quantity";
      quantity.Size = new Size(60, 62);
      quantity.TabIndex = 4;
      quantity.Text = "1";
      quantity.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      button1.BackColor = Color.FromArgb(39, 55, 77);
      button1.Cursor = Cursors.Hand;
      button1.FlatAppearance.BorderSize = 0;
      button1.FlatStyle = FlatStyle.Flat;
      button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
      button1.ForeColor = Color.White;
      button1.Location = new Point(612, 91);
      button1.Margin = new Padding(2);
      button1.Name = "button1";
      button1.Size = new Size(60, 62);
      button1.TabIndex = 3;
      button1.Text = "+";
      button1.UseVisualStyleBackColor = false;
      button1.Click += button1_Click;
      // 
      // label5
      // 
      label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      label5.AutoSize = true;
      label5.BackColor = SystemColors.AppWorkspace;
      label5.BorderStyle = BorderStyle.Fixed3D;
      label5.Location = new Point(35, 242);
      label5.Margin = new Padding(2, 0, 2, 0);
      label5.MaximumSize = new Size(0, 2);
      label5.MinimumSize = new Size(1250, 2);
      label5.Name = "label5";
      label5.Size = new Size(1250, 2);
      label5.TabIndex = 2;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 14F);
      label1.Location = new Point(283, 69);
      label1.Margin = new Padding(2, 0, 2, 0);
      label1.MaximumSize = new Size(300, 0);
      label1.MinimumSize = new Size(300, 0);
      label1.Name = "label1";
      label1.Size = new Size(300, 38);
      label1.TabIndex = 1;
      label1.Text = "label1";
      // 
      // pictureBox1
      // 
      pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
      pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
      pictureBox1.Location = new Point(35, 14);
      pictureBox1.Margin = new Padding(2);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(230, 214);
      pictureBox1.TabIndex = 0;
      pictureBox1.TabStop = false;
      // 
      // CartItemControler
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(panel1);
      Margin = new Padding(2);
      Name = "CartItemControler";
      Size = new Size(1226, 259);
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private PictureBox pictureBox1;
    private Label label5;
    private Button button4;
    private Button button3;
    private Button quantity;
    private Button button1;
    private Label label2;
  }
}
