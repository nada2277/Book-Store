namespace BookStore.User.Forms
{
  partial class SearchForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
      panel1 = new Panel();
      label1 = new Label();
      panel2 = new Panel();
      nextBtn = new Button();
      prevBtn = new Button();
      flowLayoutPanel1 = new FlowLayoutPanel();
      panel1.SuspendLayout();
      panel2.SuspendLayout();
      SuspendLayout();
      // 
      // panel1
      // 
      panel1.BackColor = Color.White;
      panel1.Controls.Add(label1);
      panel1.Dock = DockStyle.Top;
      panel1.Location = new Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(1765, 66);
      panel1.TabIndex = 0;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
      label1.ForeColor = Color.FromArgb(39, 55, 77);
      label1.Location = new Point(79, 0);
      label1.Name = "label1";
      label1.Size = new Size(151, 60);
      label1.TabIndex = 0;
      label1.Text = "label1";
      // 
      // panel2
      // 
      panel2.BackColor = Color.White;
      panel2.Controls.Add(nextBtn);
      panel2.Controls.Add(prevBtn);
      panel2.Dock = DockStyle.Bottom;
      panel2.Location = new Point(0, 584);
      panel2.Name = "panel2";
      panel2.Size = new Size(1765, 66);
      panel2.TabIndex = 1;
      // 
      // nextBtn
      // 
      nextBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      nextBtn.BackgroundImage = (Image)resources.GetObject("nextBtn.BackgroundImage");
      nextBtn.BackgroundImageLayout = ImageLayout.Stretch;
      nextBtn.Cursor = Cursors.Hand;
      nextBtn.FlatAppearance.BorderSize = 0;
      nextBtn.FlatStyle = FlatStyle.Flat;
      nextBtn.Location = new Point(1658, 3);
      nextBtn.Name = "nextBtn";
      nextBtn.Size = new Size(62, 54);
      nextBtn.TabIndex = 2;
      nextBtn.UseVisualStyleBackColor = true;
      nextBtn.Click += nextBtn_Click;
      // 
      // prevBtn
      // 
      prevBtn.BackgroundImage = (Image)resources.GetObject("prevBtn.BackgroundImage");
      prevBtn.BackgroundImageLayout = ImageLayout.Stretch;
      prevBtn.Cursor = Cursors.Hand;
      prevBtn.FlatAppearance.BorderSize = 0;
      prevBtn.FlatStyle = FlatStyle.Flat;
      prevBtn.Location = new Point(53, 3);
      prevBtn.Name = "prevBtn";
      prevBtn.Size = new Size(62, 54);
      prevBtn.TabIndex = 1;
      prevBtn.UseVisualStyleBackColor = true;
      prevBtn.Click += prevBtn_Click;
      // 
      // flowLayoutPanel1
      // 
      flowLayoutPanel1.AutoScroll = true;
      flowLayoutPanel1.BackColor = Color.White;
      flowLayoutPanel1.Dock = DockStyle.Fill;
      flowLayoutPanel1.Location = new Point(0, 66);
      flowLayoutPanel1.Name = "flowLayoutPanel1";
      flowLayoutPanel1.Padding = new Padding(120, 20, 0, 0);
      flowLayoutPanel1.Size = new Size(1765, 518);
      flowLayoutPanel1.TabIndex = 2;
      // 
      // SearchForm
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1765, 650);
      Controls.Add(flowLayoutPanel1);
      Controls.Add(panel2);
      Controls.Add(panel1);
      Name = "SearchForm";
      Text = "SearchForm";
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      panel2.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private Panel panel2;
    private Button prevBtn;
    private Button nextBtn;
    private FlowLayoutPanel flowLayoutPanel1;
  }
}