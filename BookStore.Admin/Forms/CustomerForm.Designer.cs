namespace BookStore.Admin.Forms
{
  partial class CustomerForm
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
      label1 = new Label();
      dataGridView1 = new DataGridView();
      ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(41, 53);
      label1.Name = "label1";
      label1.Size = new Size(97, 25);
      label1.TabIndex = 0;
      label1.Text = "Customers";
      // 
      // dataGridView1
      // 
      dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView1.Location = new Point(222, 40);
      dataGridView1.Name = "dataGridView1";
      dataGridView1.RowHeadersWidth = 62;
      dataGridView1.Size = new Size(554, 381);
      dataGridView1.TabIndex = 1;
      // 
      // CustomerForm
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(dataGridView1);
      Controls.Add(label1);
      Name = "CustomerForm";
      Text = "Customers";
      ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private DataGridView dataGridView1;
  }
}