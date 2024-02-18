namespace BookStore.User.Forms
{
    partial class OneCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneCategoryForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panel2 = new Panel();
            nextBtn = new Button();
            prevBtn = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 66);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(120, 20, 0, 0);
            flowLayoutPanel1.Size = new Size(1924, 454);
            flowLayoutPanel1.TabIndex = 5;
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
            panel2.Location = new Point(0, 520);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 66);
            panel2.TabIndex = 4;
            // 
            // nextBtn
            // 
            nextBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextBtn.BackgroundImage = (Image)resources.GetObject("nextBtn.BackgroundImage");
            nextBtn.BackgroundImageLayout = ImageLayout.Stretch;
            nextBtn.Cursor = Cursors.Hand;
            nextBtn.FlatAppearance.BorderSize = 0;
            nextBtn.FlatStyle = FlatStyle.Flat;
            nextBtn.Location = new Point(1788, 6);
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 66);
            panel1.TabIndex = 3;
            // 
            // OneCategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 586);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OneCategoryForm";
            Text = "OneCategoryForm";
            Load += OneCategoryForm_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Panel panel2;
        private Button nextBtn;
        private Button prevBtn;
        private Panel panel1;
    }
}