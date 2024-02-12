
using BookStore.User.Forms;

namespace BookStore.User
{
  public partial class Form1 : Form
  {
    LoginForm loginForm;
    HomeForm booksForm;
    RegistrationForm registrationForm;
    public Form1()
    {
      InitializeComponent();
      ShowLogin();
    }

    public void ShowBooks()
    {
      booksForm = new();
      booksForm.TopLevel = false;
      booksForm.FormBorderStyle = FormBorderStyle.None;
      booksForm.Dock = DockStyle.Fill;
      booksForm.Show();
      this?.Controls.Add(booksForm);
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
