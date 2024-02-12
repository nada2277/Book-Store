
namespace BookStore.User.Forms
{
  public partial class RegistrationForm : Form
  {
    Form1 mainForm;
    public RegistrationForm(Form mainForm)
    {
      InitializeComponent();
      this.mainForm = (Form1)mainForm;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      mainForm.ShowLogin();
      this.Close();
    }

  }
}
