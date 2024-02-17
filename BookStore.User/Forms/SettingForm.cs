using Autofac;
using BookStore.Application.Services;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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


        Customer customer;
      
        public SettingForm(Customer _customer)
        {
            InitializeComponent();

            //PlaceHolders:
            InitializeTextBox();

            //Pic of Profile : 
            customer = _customer;

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

            //Responsive In WINDOW:
            //this.Resize += Form1_Resize;


        }

        #region PlaceHolder IN Texts :

        private void InitializeTextBox()
        {

            textBox1.Text = PlaceholderTextFN;
            textBox2.Text = PlaceholderTextLN;
            textBox3.Text = PlaceholderTextPH;
            textBox4.Text = PlaceholderTextADD;

            SetPlaceholder(textBox1);
            SetPlaceholder(textBox2);
            SetPlaceholder(textBox3);
            SetPlaceholder(textBox4);
        }
        private void SetPlaceholder(TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.SystemColors.GrayText;
            textBox.Enter += TextBox_Enter;
            textBox.Leave += TextBox_Leave;
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
                default:
                    return "";
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







        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
