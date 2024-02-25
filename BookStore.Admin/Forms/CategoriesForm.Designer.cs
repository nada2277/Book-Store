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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            addBtn = new Button();
            updateBtn = new Button();
            getOne = new Button();
            button5 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(416, 90);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(588, 286);
            dataGridView1.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(28, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Category Name";
            textBox1.Size = new Size(279, 34);
            textBox1.TabIndex = 25;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(39, 55, 77);
            addBtn.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addBtn.ForeColor = SystemColors.ControlLightLight;
            addBtn.Location = new Point(35, 299);
            addBtn.Margin = new Padding(2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(161, 50);
            addBtn.TabIndex = 26;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(39, 55, 77);
            updateBtn.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(210, 299);
            updateBtn.Margin = new Padding(2);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(161, 50);
            updateBtn.TabIndex = 27;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // getOne
            // 
            getOne.BackColor = Color.FromArgb(39, 55, 77);
            getOne.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            getOne.ForeColor = SystemColors.ControlLightLight;
            getOne.Location = new Point(35, 391);
            getOne.Margin = new Padding(2);
            getOne.Name = "getOne";
            getOne.Size = new Size(161, 50);
            getOne.TabIndex = 28;
            getOne.Text = "Get One";
            getOne.UseVisualStyleBackColor = false;
            getOne.Click += getOne_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(39, 55, 77);
            button5.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(210, 391);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(161, 50);
            button5.TabIndex = 29;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(35, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 82);
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(680, 25);
            label1.Name = "label1";
            label1.Size = new Size(333, 63);
            label1.TabIndex = 31;
            label1.Text = "Categories";
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1025, 503);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(getOne);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "CategoriesForm";
            Text = "Categories";
            Load += CategoriesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button addBtn;
        private Button updateBtn;
        private Button getOne;
        private Button button5;
        private Panel panel1;
        private Label label1;
    }
}