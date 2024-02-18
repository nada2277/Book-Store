
using Autofac;
using BookStore.Application.Services;
using BookStore.Models;
using System.Text.RegularExpressions;
using Test.Presentation.AutoFag;

namespace BookStore.User.Forms
{
    public partial class RegistrationForm : Form
    {
        Form1 mainForm;
        public RegistrationForm(Form mainForm)
        {
            InitializeComponent();

            this.mainForm = (Form1)mainForm;
            TextBox txtPassword = new TextBox();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.ShowLogin();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionCustomer = AutoFag.RegisterCustomer();
            ICustomerService CustomerService = connectionCustomer.Resolve<ICustomerService>();

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            // Reset validation labels
            lblFirstNameError.Text = "";
            lblLastNameError.Text = "";
            lblEmailError.Text = "";
            lblUsernameError.Text = "";
            lblPasswordError.Text = "";
            lblConfirmPasswordError.Text = "";
            lblPhoneError.Text = "";
            lblAddressError.Text = "";

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
                lblEmailError.Text = "Sorry this email is exisited";
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
                lblPasswordError.Text = "Password is required";
                isValid = false;
            }

            if (password != confirmPassword)
            {
                lblConfirmPasswordError.Text = "Passwords do not match";
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

            bool success = CustomerService.AddCustomer(newCustomer);

            if (success)
            {
                this.Close();
                mainForm.ShowLogin();
            }
            //{
            //    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Failed to add customer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

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


    }
}
