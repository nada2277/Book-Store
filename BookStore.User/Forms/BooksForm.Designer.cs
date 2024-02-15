

namespace BookStore.User.Forms
{
  partial class BooksForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
      panel1 = new Panel();
      nextBtn = new Button();
      prevBtn = new Button();
      mainPanel = new FlowLayoutPanel();
      panel1.SuspendLayout();
      SuspendLayout();
      // 
      // panel1
      // 
      panel1.BackColor = Color.White;
      panel1.Controls.Add(nextBtn);
      panel1.Controls.Add(prevBtn);
      panel1.Dock = DockStyle.Bottom;
      panel1.Location = new Point(0, 932);
      panel1.Name = "panel1";
      panel1.Size = new Size(1612, 66);
      panel1.TabIndex = 1;
      // 
      // nextBtn
      // 
      nextBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      nextBtn.BackgroundImage = (Image)resources.GetObject("nextBtn.BackgroundImage");
      nextBtn.BackgroundImageLayout = ImageLayout.Stretch;
      nextBtn.Cursor = Cursors.Hand;
      nextBtn.FlatAppearance.BorderSize = 0;
      nextBtn.FlatStyle = FlatStyle.Flat;
      nextBtn.Location = new Point(1498, 6);
      nextBtn.Name = "nextBtn";
      nextBtn.Size = new Size(62, 54);
      nextBtn.TabIndex = 1;
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
      prevBtn.Location = new Point(47, 6);
      prevBtn.Name = "prevBtn";
      prevBtn.Size = new Size(62, 54);
      prevBtn.TabIndex = 0;
      prevBtn.UseVisualStyleBackColor = true;
      prevBtn.Click += prevBtn_Click;
      // 
      // mainPanel
      // 
      mainPanel.Dock = DockStyle.Fill;
      mainPanel.Location = new Point(0, 0);
      mainPanel.Name = "mainPanel";
      mainPanel.Padding = new Padding(120, 0, 0, 0);
      mainPanel.Size = new Size(1612, 932);
      mainPanel.TabIndex = 2;
      // 
      // BooksForm
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoScroll = true;
      BackColor = Color.White;
      ClientSize = new Size(1612, 998);
      Controls.Add(mainPanel);
      Controls.Add(panel1);
      Name = "BooksForm";
      Text = "BookForm";
      panel1.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion
    private Panel panel1;
    private Button nextBtn;
    private Button prevBtn;
    private FlowLayoutPanel mainPanel;
  }
}