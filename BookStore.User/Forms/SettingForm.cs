using Autofac;
using BookStore.Admin;
using BookStore.Application.Services;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Presentation.AutoFag;

namespace BookStore.User.Forms
{
    public partial class SettingForm : Form
    {
        private const string PlaceholderTextFN = "Enter First Name";
        private const string PlaceholderTextLN = "Enter Last Name";
        private const string PlaceholderTextPH = "Enter Phone";
        private const string PlaceholderTextADD = "Enter Address";
        private const string PlaceholderTextUS = "Enter UserName";
        private const string PlaceholderTextEm = "Enter Email";
        private const string PlaceholderTextPass = "Enter Current Password";
        private const string PlaceholderTextPasscon = "Enter New  Password";


        Customer customer;


        Form1 mainForm;
        public SettingForm(Customer _customer)
        {
            InitializeComponent();

            //PlaceHolders:
            InitializeTextBox();


            //Pic of Profile : 
            customer = _customer;
            SetProfilePicture();

            //set buttton rounded 
            SetRoundedButton(button2);



            //Responsive In WINDOW:
            //this.Resize += Form1_Resize;



            //Validations :
            this.mainForm = (Form1)mainForm;


        }

        #region PlaceHolder IN Texts :

        private void InitializeTextBox()
        {

            textBox1.Text = PlaceholderTextFN;
            textBox2.Text = PlaceholderTextLN;
            textBox3.Text = PlaceholderTextPH;
            textBox4.Text = PlaceholderTextADD;
            textBox5.Text = PlaceholderTextUS;
            textBox6.Text = PlaceholderTextEm;
            textBox7.Text = PlaceholderTextPass;
            textBox8.Text = PlaceholderTextPasscon;

            SetPlaceholder(textBox1);
            SetPlaceholder(textBox2);
            SetPlaceholder(textBox3);
            SetPlaceholder(textBox4);
            SetPlaceholder(textBox5);
            SetPlaceholder(textBox6);
            SetPlaceholder(textBox7);
            SetPlaceholder(textBox8);
        }
        private void SetPlaceholder(TextBox textBox)
        {
            textBox.Font = new Font(textBox.Font.FontFamily, 12f, FontStyle.Regular); // Adjust the font size (12f) as needed
            textBox.ForeColor = SystemColors.GrayText;
            textBox.Enter += TextBox_Enter;
            textBox.Leave += TextBox_Leave;

            // Calculate the vertical padding to center the placeholder text vertically
            int verticalPadding = (textBox.Height - (int)textBox.Font.GetHeight()) / 2;
            textBox.Padding = new Padding(5, verticalPadding, 0, 0); // Adjust the left padding as needed

            // Set the TextAlign property to align text to the left
            textBox.TextAlign = HorizontalAlignment.Left;
        }



        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == GetPlaceholderText(textBox))
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = GetPlaceholderText(textBox);
                textBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private string GetPlaceholderText(TextBox textBox)
        {
            switch (textBox.Name)
            {
                case "textBox1":
                    return PlaceholderTextFN;
                case "textBox2":
                    return PlaceholderTextLN;
                case "textBox3":
                    return PlaceholderTextPH;
                case "textBox4":
                    return PlaceholderTextADD;
                case "textBox5":
                    return PlaceholderTextUS;
                case "textBox6":
                    return PlaceholderTextEm;
                case "textBox7":
                    return PlaceholderTextPass;
                case "textBox8":
                    return PlaceholderTextPasscon;
                default:
                    return "";
            }
        }

        #endregion

        #region Pic :


        private void SetProfilePicture()
        {
            var connectionCustomer = AutoFag.RegisterCustomer();
            ICustomerService CustomerService = connectionCustomer.Resolve<ICustomerService>();

            string imagePath = Path.GetFullPath($"..\\..\\..\\Images\\{customer.ProfilePic}");

            Image image = Image.FromFile(imagePath);

            // Make image rounded
            Bitmap roundedImage = new Bitmap(image.Width, image.Height);
            using (Graphics graphics = Graphics.FromImage(roundedImage))
            {
                graphics.Clear(Color.Transparent);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                graphics.FillEllipse(new TextureBrush(image), 0, 0, image.Width, image.Height);

                // Assign rounded image to PictureBox
                pictureBox1.Image = roundedImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        #endregion

        #region Layout Of Page : 

        //private void Form1_Resize(object sender, EventArgs e)
        //{
        //    // Resize and reposition PictureBox
        //    int pictureBoxWidth = (int)(this.ClientSize.Width * 0.3); // 30% of form width
        //    int pictureBoxHeight = (int)(this.ClientSize.Height * 0.3); // 30% of form height
        //    int pictureBoxX = (int)(this.ClientSize.Width * 0.05); // 5% from left
        //    int pictureBoxY = (int)(this.ClientSize.Height * 0.05); // 5% from top

        //    pictureBox1.Size = new Size(pictureBoxWidth, pictureBoxHeight);
        //    pictureBox1.Location = new Point(pictureBoxX, pictureBoxY);

        //    // Resize and reposition TextBox controls
        //    int textBoxWidth = (int)(this.ClientSize.Width * 0.2); // 20% of form width
        //    int textBoxHeight = (int)(this.ClientSize.Height * 0.05); // 5% of form height

        //    int textBox1X = (int)(this.ClientSize.Width * 0.4); // 40% from left
        //    int textBox1Y = pictureBoxY; // Same as PictureBox Y position
        //    textBox1.Size = new Size(textBoxWidth, textBoxHeight);
        //    textBox1.Location = new Point(textBox1X, textBox1Y);

        //    // Adjust positions for other TextBox controls similarly
        //    int spacing = 10; // Adjust the spacing between TextBox controls

        //    int textBox2X = textBox1X; // Same as TextBox1 X position
        //    int textBox2Y = textBox1Y + textBoxHeight + spacing; // Add spacing below TextBox1
        //    textBox2.Size = new Size(textBoxWidth, textBoxHeight);
        //    textBox2.Location = new Point(textBox2X, textBox2Y);

        //    int textBox3X = textBox1X; // Same as TextBox1 X position
        //    int textBox3Y = textBox2Y + textBoxHeight + spacing; // Add spacing below TextBox2
        //    textBox3.Size = new Size(textBoxWidth, textBoxHeight);
        //    textBox3.Location = new Point(textBox3X, textBox3Y);

        //    int textBox4X = textBox1X; // Same as TextBox1 X position
        //    int textBox4Y = textBox3Y + textBoxHeight + spacing; // Add spacing below TextBox3
        //    textBox4.Size = new Size(textBoxWidth, textBoxHeight);
        //    textBox4.Location = new Point(textBox4X, textBox4Y);

        //    // Repeat this pattern for additional TextBox controls as needed
        //}


        #endregion


        #region Validations :
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.ShowLogin();
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var connectionCustomer = AutoFag.RegisterCustomer();
            ICustomerService CustomerService = connectionCustomer.Resolve<ICustomerService>();

            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            string phone = textBox3.Text.Trim();
            string address = textBox4.Text.Trim();
            string username = textBox5.Text.Trim();
            string email = textBox6.Text.Trim();
            string password = textBox7.Text;
            string newPassword = textBox8.Text;

            // Reset validation labels
            lblFirstNameError.Text = "";
            lblLastNameError.Text = "";
            lblPhoneError.Text = "";
            lblAddressError.Text = "";
            lblUsernameError.Text = "";
            lblEmailError.Text = "";
            lblPasswordError.Text = "";
            lblNewPasswordError.Text = "";

            // Validation
            bool isValid = true;

            if (string.IsNullOrEmpty(firstName))
            {
                lblFirstNameError.Text = "First name is required";
                isValid = false;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                lblLastNameError.Text = "Last name is required";
                isValid = false;
            }

            if (string.IsNullOrEmpty(email))
            {
                lblEmailError.Text = "Email is required";
                isValid = false;
            }
            else if (!IsValidEmail(email))
            {
                lblEmailError.Text = "Invalid email format";
                isValid = false;
            }
            else if (CustomerService.IsUsrEmailExisit(email))
            {
                lblEmailError.Text = "Sorry This email Is Exisited";
                isValid = false;
            }


            if (string.IsNullOrEmpty(username))
            {
                lblUsernameError.Text = "Username is required";
                isValid = false;
            }
            else if (CustomerService.IsUsrNameExisit(username))
            {
                lblUsernameError.Text = "Sorry this username is exisited";
                isValid = false;
            }


            if (string.IsNullOrEmpty(password))
            {
                lblPasswordError.Text = "Current Password is required";
                isValid = false;
            }

            if (!CustomerService.IsUsrPassExisit(password))
            {
                lblNewPasswordError.Text = "Current Password Does not Exist";
                isValid = false;
            }



            if (string.IsNullOrEmpty(phone))
            {
                lblPhoneError.Text = "Phone is required";
                isValid = false;
            }
            else if (!IsValidPhone(phone))
            {
                lblPhoneError.Text = "Invalid phone format";
                isValid = false;
            }
            else if (CustomerService.IsUsrPhoneExisit(phone))
            {
                lblPhoneError.Text = "Sorry this phone is exisited";
                isValid = false;
            }



            if (string.IsNullOrEmpty(address))
            {
                lblAddressError.Text = "Address is required";
                isValid = false;
            }

            if (!isValid)
                return;


            Customer newCustomer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                UserName = username,
                Password = password,
                Phone = phone,
                Address = address,
                IsAdmin = false,
                ProfilePic = "profilePicture.png"
            };

            bool success = CustomerService.UpdateCustomer(newCustomer);

            if (success)
            {
                this.Close();
                mainForm.ShowLogin();
            }


        }

        bool IsValidPhone(string phone)
        {
            string pattern = @"^(?!01\d{8}$).*";
            return Regex.IsMatch(phone, pattern);
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        #endregion




        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = openFileDialog.FileName;
                    Image selectedImage = Image.FromFile(selectedImagePath);

                    // Assign the selected image to the PictureBox
                    pictureBox1.Image = selectedImage;
                    customer.ProfilePic = selectedImagePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void SetRoundedButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.FromArgb(39, 55, 77); button.ForeColor = Color.White;

            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Set the radius for rounding the corners
            Rectangle bounds = button.ClientRectangle;
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            button.Region = new Region(path);
        }



    }
}
