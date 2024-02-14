namespace BookStore.User.Forms
{
  partial class RegistrationForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
      pictureBox1 = new PictureBox();
      panel1 = new Panel();
      lblPhoneError = new Label();
      panel10 = new Panel();
      txtPhone = new TextBox();
      lblAddressError = new Label();
      panel9 = new Panel();
      txtAddress = new TextBox();
      lblConfirmPasswordError = new Label();
      lblPasswordError = new Label();
      lblEmailError = new Label();
      lblUsernameError = new Label();
      lblLastNameError = new Label();
      lblFirstNameError = new Label();
      panel8 = new Panel();
      txtConfirmPassword = new TextBox();
      panel7 = new Panel();
      txtPassword = new TextBox();
      panel6 = new Panel();
      txtEmail = new TextBox();
      panel5 = new Panel();
      txtUsername = new TextBox();
      panel4 = new Panel();
      txtLastName = new TextBox();
      panel3 = new Panel();
      txtFirstName = new TextBox();
      linkLabel1 = new LinkLabel();
      label8 = new Label();
      button1 = new Button();
      label1 = new Label();
      panel2 = new Panel();
      fileSystemWatcher1 = new FileSystemWatcher();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      panel1.SuspendLayout();
      panel10.SuspendLayout();
      panel9.SuspendLayout();
      panel8.SuspendLayout();
      panel7.SuspendLayout();
      panel6.SuspendLayout();
      panel5.SuspendLayout();
      panel4.SuspendLayout();
      panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
      SuspendLayout();
      // 
      // pictureBox1
      // 
      pictureBox1.Dock = DockStyle.Fill;
      pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
      pictureBox1.Location = new Point(623, 0);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(1270, 944);
      pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
      pictureBox1.TabIndex = 1;
      pictureBox1.TabStop = false;
      // 
      // panel1
      // 
      panel1.BackColor = Color.FromArgb(39, 55, 77);
      panel1.Controls.Add(lblPhoneError);
      panel1.Controls.Add(panel10);
      panel1.Controls.Add(lblAddressError);
      panel1.Controls.Add(panel9);
      panel1.Controls.Add(lblConfirmPasswordError);
      panel1.Controls.Add(lblPasswordError);
      panel1.Controls.Add(lblEmailError);
      panel1.Controls.Add(lblUsernameError);
      panel1.Controls.Add(lblLastNameError);
      panel1.Controls.Add(lblFirstNameError);
      panel1.Controls.Add(panel8);
      panel1.Controls.Add(panel7);
      panel1.Controls.Add(panel6);
      panel1.Controls.Add(panel5);
      panel1.Controls.Add(panel4);
      panel1.Controls.Add(panel3);
      panel1.Controls.Add(linkLabel1);
      panel1.Controls.Add(label8);
      panel1.Controls.Add(button1);
      panel1.Controls.Add(label1);
      panel1.Dock = DockStyle.Left;
      panel1.Location = new Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(623, 944);
      panel1.TabIndex = 2;
      // 
      // lblPhoneError
      // 
      lblPhoneError.AutoSize = true;
      lblPhoneError.ForeColor = Color.FromArgb(255, 192, 192);
      lblPhoneError.Location = new Point(21, 576);
      lblPhoneError.Name = "lblPhoneError";
      lblPhoneError.Size = new Size(0, 25);
      lblPhoneError.TabIndex = 29;
      // 
      // panel10
      // 
      panel10.BackColor = Color.FromArgb(238, 238, 238);
      panel10.BorderStyle = BorderStyle.Fixed3D;
      panel10.Controls.Add(txtPhone);
      panel10.Location = new Point(21, 516);
      panel10.Name = "panel10";
      panel10.Padding = new Padding(10, 3, 10, 3);
      panel10.Size = new Size(530, 57);
      panel10.TabIndex = 22;
      // 
      // txtPhone
      // 
      txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      txtPhone.BackColor = Color.FromArgb(238, 238, 238);
      txtPhone.BorderStyle = BorderStyle.None;
      txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtPhone.Location = new Point(16, 9);
      txtPhone.Name = "txtPhone";
      txtPhone.PlaceholderText = "Phone";
      txtPhone.Size = new Size(497, 32);
      txtPhone.TabIndex = 3;
      // 
      // lblAddressError
      // 
      lblAddressError.AutoSize = true;
      lblAddressError.ForeColor = Color.FromArgb(255, 192, 192);
      lblAddressError.Location = new Point(21, 475);
      lblAddressError.Name = "lblAddressError";
      lblAddressError.Size = new Size(0, 25);
      lblAddressError.TabIndex = 28;
      // 
      // panel9
      // 
      panel9.BackColor = Color.FromArgb(238, 238, 238);
      panel9.BorderStyle = BorderStyle.Fixed3D;
      panel9.Controls.Add(txtAddress);
      panel9.Location = new Point(21, 415);
      panel9.Name = "panel9";
      panel9.Padding = new Padding(10, 3, 10, 3);
      panel9.Size = new Size(530, 57);
      panel9.TabIndex = 21;
      // 
      // txtAddress
      // 
      txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      txtAddress.BackColor = Color.FromArgb(238, 238, 238);
      txtAddress.BorderStyle = BorderStyle.None;
      txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtAddress.Location = new Point(16, 9);
      txtAddress.Name = "txtAddress";
      txtAddress.PlaceholderText = "Address";
      txtAddress.Size = new Size(497, 32);
      txtAddress.TabIndex = 3;
      // 
      // lblConfirmPasswordError
      // 
      lblConfirmPasswordError.AutoSize = true;
      lblConfirmPasswordError.ForeColor = Color.FromArgb(255, 192, 192);
      lblConfirmPasswordError.Location = new Point(21, 774);
      lblConfirmPasswordError.Name = "lblConfirmPasswordError";
      lblConfirmPasswordError.Size = new Size(0, 25);
      lblConfirmPasswordError.TabIndex = 27;
      // 
      // lblPasswordError
      // 
      lblPasswordError.AutoSize = true;
      lblPasswordError.ForeColor = Color.FromArgb(255, 192, 192);
      lblPasswordError.Location = new Point(21, 678);
      lblPasswordError.Name = "lblPasswordError";
      lblPasswordError.Size = new Size(0, 25);
      lblPasswordError.TabIndex = 26;
      // 
      // lblEmailError
      // 
      lblEmailError.AutoSize = true;
      lblEmailError.ForeColor = Color.FromArgb(255, 192, 192);
      lblEmailError.Location = new Point(21, 372);
      lblEmailError.Name = "lblEmailError";
      lblEmailError.Size = new Size(0, 25);
      lblEmailError.TabIndex = 25;
      // 
      // lblUsernameError
      // 
      lblUsernameError.AutoSize = true;
      lblUsernameError.ForeColor = Color.FromArgb(255, 192, 192);
      lblUsernameError.Location = new Point(21, 270);
      lblUsernameError.Name = "lblUsernameError";
      lblUsernameError.Size = new Size(0, 25);
      lblUsernameError.TabIndex = 24;
      // 
      // lblLastNameError
      // 
      lblLastNameError.AutoSize = true;
      lblLastNameError.ForeColor = Color.FromArgb(255, 192, 192);
      lblLastNameError.Location = new Point(309, 165);
      lblLastNameError.Name = "lblLastNameError";
      lblLastNameError.Size = new Size(0, 25);
      lblLastNameError.TabIndex = 23;
      // 
      // lblFirstNameError
      // 
      lblFirstNameError.AutoSize = true;
      lblFirstNameError.ForeColor = Color.FromArgb(255, 192, 192);
      lblFirstNameError.Location = new Point(21, 165);
      lblFirstNameError.Name = "lblFirstNameError";
      lblFirstNameError.Size = new Size(0, 25);
      lblFirstNameError.TabIndex = 22;
      // 
      // panel8
      // 
      panel8.BackColor = Color.FromArgb(238, 238, 238);
      panel8.BorderStyle = BorderStyle.Fixed3D;
      panel8.Controls.Add(txtConfirmPassword);
      panel8.Location = new Point(21, 714);
      panel8.Name = "panel8";
      panel8.Padding = new Padding(10, 3, 10, 3);
      panel8.Size = new Size(530, 57);
      panel8.TabIndex = 21;
      // 
      // txtConfirmPassword
      // 
      txtConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      txtConfirmPassword.BackColor = Color.FromArgb(238, 238, 238);
      txtConfirmPassword.BorderStyle = BorderStyle.None;
      txtConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtConfirmPassword.Location = new Point(6, 9);
      txtConfirmPassword.Name = "txtConfirmPassword";
      txtConfirmPassword.PasswordChar = '*';
      txtConfirmPassword.PlaceholderText = "Confirm Password";
      txtConfirmPassword.Size = new Size(497, 32);
      txtConfirmPassword.TabIndex = 3;
      // 
      // panel7
      // 
      panel7.BackColor = Color.FromArgb(238, 238, 238);
      panel7.BorderStyle = BorderStyle.Fixed3D;
      panel7.Controls.Add(txtPassword);
      panel7.Location = new Point(21, 618);
      panel7.Name = "panel7";
      panel7.Padding = new Padding(10, 3, 10, 3);
      panel7.Size = new Size(530, 57);
      panel7.TabIndex = 20;
      // 
      // txtPassword
      // 
      txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      txtPassword.BackColor = Color.FromArgb(238, 238, 238);
      txtPassword.BorderStyle = BorderStyle.None;
      txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtPassword.Location = new Point(13, 9);
      txtPassword.Name = "txtPassword";
      txtPassword.PasswordChar = '*';
      txtPassword.PlaceholderText = "Password";
      txtPassword.Size = new Size(500, 32);
      txtPassword.TabIndex = 3;
      // 
      // panel6
      // 
      panel6.BackColor = Color.FromArgb(238, 238, 238);
      panel6.BorderStyle = BorderStyle.Fixed3D;
      panel6.Controls.Add(txtEmail);
      panel6.Location = new Point(21, 312);
      panel6.Name = "panel6";
      panel6.Padding = new Padding(10, 3, 10, 3);
      panel6.Size = new Size(530, 57);
      panel6.TabIndex = 19;
      // 
      // txtEmail
      // 
      txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      txtEmail.BackColor = Color.FromArgb(238, 238, 238);
      txtEmail.BorderStyle = BorderStyle.None;
      txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtEmail.Location = new Point(16, 9);
      txtEmail.Name = "txtEmail";
      txtEmail.PlaceholderText = "Email";
      txtEmail.Size = new Size(497, 32);
      txtEmail.TabIndex = 3;
      // 
      // panel5
      // 
      panel5.BackColor = Color.FromArgb(238, 238, 238);
      panel5.BorderStyle = BorderStyle.Fixed3D;
      panel5.Controls.Add(txtUsername);
      panel5.Location = new Point(21, 210);
      panel5.Name = "panel5";
      panel5.Padding = new Padding(10, 3, 10, 3);
      panel5.Size = new Size(530, 57);
      panel5.TabIndex = 18;
      // 
      // txtUsername
      // 
      txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      txtUsername.BackColor = Color.FromArgb(238, 238, 238);
      txtUsername.BorderStyle = BorderStyle.None;
      txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtUsername.Location = new Point(16, 9);
      txtUsername.Name = "txtUsername";
      txtUsername.PlaceholderText = "User Name";
      txtUsername.Size = new Size(497, 32);
      txtUsername.TabIndex = 3;
      // 
      // panel4
      // 
      panel4.BackColor = Color.FromArgb(238, 238, 238);
      panel4.BorderStyle = BorderStyle.Fixed3D;
      panel4.Controls.Add(txtLastName);
      panel4.Location = new Point(309, 113);
      panel4.Name = "panel4";
      panel4.Padding = new Padding(10, 3, 10, 3);
      panel4.Size = new Size(242, 49);
      panel4.TabIndex = 17;
      // 
      // txtLastName
      // 
      txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      txtLastName.BackColor = Color.FromArgb(238, 238, 238);
      txtLastName.BorderStyle = BorderStyle.None;
      txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtLastName.Location = new Point(13, 6);
      txtLastName.Name = "txtLastName";
      txtLastName.PlaceholderText = "Last Name";
      txtLastName.Size = new Size(202, 32);
      txtLastName.TabIndex = 3;
      // 
      // panel3
      // 
      panel3.BackColor = Color.FromArgb(238, 238, 238);
      panel3.Controls.Add(txtFirstName);
      panel3.Location = new Point(21, 113);
      panel3.Name = "panel3";
      panel3.Padding = new Padding(10, 3, 10, 3);
      panel3.Size = new Size(230, 49);
      panel3.TabIndex = 16;
      // 
      // txtFirstName
      // 
      txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      txtFirstName.BackColor = Color.FromArgb(238, 238, 238);
      txtFirstName.BorderStyle = BorderStyle.None;
      txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtFirstName.Location = new Point(13, 6);
      txtFirstName.Name = "txtFirstName";
      txtFirstName.PlaceholderText = "First Name";
      txtFirstName.Size = new Size(169, 32);
      txtFirstName.TabIndex = 3;
      // 
      // linkLabel1
      // 
      linkLabel1.AutoSize = true;
      linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
      linkLabel1.LinkColor = Color.White;
      linkLabel1.Location = new Point(270, 896);
      linkLabel1.Name = "linkLabel1";
      linkLabel1.Size = new Size(59, 25);
      linkLabel1.TabIndex = 15;
      linkLabel1.TabStop = true;
      linkLabel1.Text = "Login";
      linkLabel1.LinkClicked += linkLabel1_LinkClicked;
      // 
      // label8
      // 
      label8.AutoSize = true;
      label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label8.ForeColor = Color.FromArgb(255, 192, 192);
      label8.Location = new Point(21, 899);
      label8.Name = "label8";
      label8.Size = new Size(243, 22);
      label8.TabIndex = 14;
      label8.Text = "Already Have An Acount ?";
      // 
      // button1
      // 
      button1.BackColor = Color.WhiteSmoke;
      button1.Cursor = Cursors.Hand;
      button1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
      button1.ForeColor = Color.FromArgb(39, 55, 77);
      button1.Location = new Point(21, 829);
      button1.Name = "button1";
      button1.Size = new Size(530, 67);
      button1.TabIndex = 13;
      button1.Text = "Sign Up";
      button1.UseVisualStyleBackColor = false;
      button1.Click += button1_Click;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label1.ForeColor = Color.White;
      label1.Location = new Point(21, 32);
      label1.Name = "label1";
      label1.Size = new Size(180, 51);
      label1.TabIndex = 0;
      label1.Text = "Sign Up";
      // 
      // panel2
      // 
      panel2.Location = new Point(621, 0);
      panel2.Name = "panel2";
      panel2.Size = new Size(1495, 906);
      panel2.TabIndex = 3;
      // 
      // fileSystemWatcher1
      // 
      fileSystemWatcher1.EnableRaisingEvents = true;
      fileSystemWatcher1.SynchronizingObject = this;
      // 
      // RegistrationForm
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1893, 944);
      Controls.Add(pictureBox1);
      Controls.Add(panel1);
      Controls.Add(panel2);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      Name = "RegistrationForm";
      Text = "RegistrationForm";
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      panel10.ResumeLayout(false);
      panel10.PerformLayout();
      panel9.ResumeLayout(false);
      panel9.PerformLayout();
      panel8.ResumeLayout(false);
      panel8.PerformLayout();
      panel7.ResumeLayout(false);
      panel7.PerformLayout();
      panel6.ResumeLayout(false);
      panel6.PerformLayout();
      panel5.ResumeLayout(false);
      panel5.PerformLayout();
      panel4.ResumeLayout(false);
      panel4.PerformLayout();
      panel3.ResumeLayout(false);
      panel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
      ResumeLayout(false);
    }

    #endregion
    private PictureBox pictureBox1;
    private Panel panel1;
    private Label label1;
    private Button button1;
    private LinkLabel linkLabel1;
    private Label label8;
    private Panel panel2;
    private FileSystemWatcher fileSystemWatcher1;
        private Panel panel3;
        private TextBox txtFirstName;
        private Panel panel5;
        private TextBox txtUsername;
        private Panel panel4;
        private TextBox txtLastName;
        private Panel panel8;
        private TextBox txtConfirmPassword;
        private Panel panel7;
        private TextBox txtPassword;
        private Panel panel6;
        private TextBox txtEmail;
        private Panel panel9;
        private TextBox txtAddress;
        private Panel panel10;
        private TextBox txtPhone;
    private Label lblConfirmPasswordError;
    private Label lblPasswordError;
    private Label lblPhoneError;
    private Label lblAddressError;
    private Label lblEmailError;
    private Label lblUsernameError;
    private Label lblLastNameError;
    private Label lblFirstNameError;
  }
}
