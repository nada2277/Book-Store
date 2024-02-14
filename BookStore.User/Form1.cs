
using BookStore.Admin;
using BookStore.Models;
using BookStore.User.Forms;

namespace BookStore.User
{
  public partial class Form1 : Form
  {
    LoginForm loginForm;
    HomeForm homeForm;
    AdminForm adminForm;
    RegistrationForm registrationForm;
    public Form1()
    {
      InitializeComponent();
      ShowLogin();
    }

    public void ShowUserForm(Customer customer)
    {
      homeForm = new HomeForm(customer);
      homeForm.TopLevel = false;
      homeForm.FormBorderStyle = FormBorderStyle.None;
      homeForm.Dock = DockStyle.Fill;
      homeForm.Show();
      this?.Controls.Add(homeForm);
    }
    public void ShowAdminForm(Customer customer)
    {
      adminForm = new AdminForm();
      adminForm.TopLevel = false;
      adminForm.FormBorderStyle = FormBorderStyle.None;
      adminForm.Dock = DockStyle.Fill;
      adminForm.Show();
      this?.Controls.Add(adminForm);
    }
    public void ShowRegistration()
    {
      registrationForm = new(this);
      registrationForm.TopLevel = false;
      registrationForm.FormBorderStyle = FormBorderStyle.None;
      registrationForm.Dock = DockStyle.Fill;
      this.Controls.Add(registrationForm);
      registrationForm.Show();
    }
    public void ShowLogin()
    {
      loginForm = new(this);
      loginForm.TopLevel = false;
      loginForm.FormBorderStyle = FormBorderStyle.None;
      loginForm.Dock = DockStyle.Fill;
      this.Controls.Add(loginForm);
      loginForm.Show();

    }
  }
}
