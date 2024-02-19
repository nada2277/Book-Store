namespace BookStore.Admin.Forms
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
            dataGridView1 = new DataGridView();
            getOne = new Button();
            addBtn = new Button();
            updateBtn = new Button();
            button5 = new Button();
            nextBtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            prevBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(570, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(827, 620);
            dataGridView1.TabIndex = 0;
            // 
            // getOne
            // 
            getOne.Location = new Point(56, 653);
            getOne.Name = "getOne";
            getOne.Size = new Size(230, 67);
            getOne.TabIndex = 4;
            getOne.Text = "Get One";
            getOne.UseVisualStyleBackColor = true;
            getOne.Click += getOne_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(60, 555);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(230, 67);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(317, 555);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(230, 67);
            updateBtn.TabIndex = 6;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // button5
            // 
            button5.Location = new Point(317, 653);
            button5.Name = "button5";
            button5.Size = new Size(230, 67);
            button5.TabIndex = 7;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // nextBtn
            // 
            nextBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextBtn.Location = new Point(1213, 686);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(184, 52);
            nextBtn.TabIndex = 8;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(56, 80);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.MaximumSize = new Size(355, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Book Name";
            textBox1.Size = new Size(355, 54);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(56, 185);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Stock";
            textBox2.Size = new Size(355, 54);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(56, 286);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Description";
            textBox3.Size = new Size(355, 54);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(56, 374);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Price";
            textBox4.Size = new Size(355, 54);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(56, 470);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Image";
            textBox5.Size = new Size(355, 54);
            textBox5.TabIndex = 14;
            // 
            // prevBtn
            // 
            prevBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            prevBtn.Location = new Point(570, 686);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(184, 52);
            prevBtn.TabIndex = 9;
            prevBtn.Text = "Previous";
            prevBtn.UseVisualStyleBackColor = true;
            prevBtn.Click += prevBtn_Click;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 787);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(prevBtn);
            Controls.Add(nextBtn);
            Controls.Add(button5);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(getOne);
            Controls.Add(dataGridView1);
            Name = "BooksForm";
            Text = "Books";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button getOne;
        private Button addBtn;
        private Button updateBtn;
        private Button button5;
        private Button nextBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button prevBtn;
    }
}