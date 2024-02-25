

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

namespace BookStore.User.Forms
{
  public partial class LoginForm : Form
  {
    Form1 mainForm;
    public LoginForm(Form mainForm)
    {
      this.ActiveControl = null;
      InitializeComponent();
      this.mainForm = (Form1)mainForm;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var connectionCustomer = AutoFag.RegisterCustomer();
      ICustomerService CustomerService = connectionCustomer.Resolve<ICustomerService>();

      if (CustomerService.IsUsrNameExisit(textBox2.Text.ToString()))
      {
        Customer customer = CustomerService.IsLogin(textBox2.Text, textBox1.Text);
        if (customer is not null)
        {
          this.Close();
          if (!customer.IsAdmin)
            mainForm.ShowUserForm(customer);
          else
            mainForm.ShowAdminForm(customer);
        }
        else
          label3.Text = "Wrong Passwprd";
      }
      else
        label3.Text = "Wrong UserName";
      label3.Visible = true;
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

      this.Close();
      mainForm.ShowRegistration();
    }
  }
}
