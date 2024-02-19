namespace BookStore.Admin.Forms
{
  partial class CategoriesForm
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
            textBox1 = new TextBox();
            button5 = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            getOne = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(46, 54);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.MaximumSize = new Size(355, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Category Name";
            textBox1.Size = new Size(355, 54);
            textBox1.TabIndex = 22;
            // 
            // button5
            // 
            button5.Location = new Point(307, 647);
            button5.Name = "button5";
            button5.Size = new Size(230, 67);
            button5.TabIndex = 19;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(307, 549);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(230, 67);
            updateBtn.TabIndex = 18;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(50, 549);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(230, 67);
            addBtn.TabIndex = 17;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // getOne
            // 
            getOne.Location = new Point(46, 647);
            getOne.Name = "getOne";
            getOne.Size = new Size(230, 67);
            getOne.TabIndex = 16;
            getOne.Text = "Get One";
            getOne.UseVisualStyleBackColor = true;
            getOne.Click += getOne_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(554, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(832, 644);
            dataGridView1.TabIndex = 23;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 787);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(getOne);
            MinimumSize = new Size(1454, 843);
            Name = "CategoriesForm";
            Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button5;
        private Button updateBtn;
        private Button addBtn;
        private Button getOne;
        private DataGridView dataGridView1;
    }
}