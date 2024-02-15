


using Autofac;
using BookStore.Application.Services;
using BookStore.Models;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Test.Presentation.AutoFag;

namespace BookStore.User.Forms
{

  public partial class HomeForm : Form
  {
    private Form activeForm = new Form();
    private BooksForm booksForm;
    private CartForm cartForm = new CartForm();
    private OrdersForm ordersForm = new OrdersForm();
    private CategoriesForm categoriesForm = new CategoriesForm();
    private SettingForm settingForm = new SettingForm();
    Form1 mainForm;

    Customer customer;
    int pageNum;
    int maxPageNum;
    IContainer connectionBook;
    IBookService BookService;

    public HomeForm(Customer _customer, Form1 form)
    {
      InitializeComponent();

      mainForm = form;

      connectionBook = AutoFag.RegisterBook();
      BookService = connectionBook.Resolve<IBookService>();
      customer = _customer;

      pageNum = 1;
      maxPageNum = BookService.GetCount();
      booksForm = new BooksForm(BookService.GetAllPagination(10, pageNum), customer.Id);
      prevBtn.Visible = false;

      fnameLabel.Text = customer.FirstName[0].ToString().ToUpper() + customer.FirstName[1..];

      pictureBox1.BackgroundImage = Image.FromFile(Path.GetFullPath($"..\\..\\..\\Images\\{customer.ProfilePic}"));

      if (!customer.ProfilePic.Equals("profilePicture.png"))
        pictureBox1.BackColor = Color.Transparent;

      pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

      System.Drawing.Drawing2D.GraphicsPath graphicsPath = new();

      graphicsPath.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);

      Region region = new Region(graphicsPath);
      pictureBox1.Region = region;
      OpenForm(booksForm, this);
      button1.BackColor = Color.FromArgb(157, 178, 191);

      searchPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, searchPanel.Width, searchPanel.Height, 50, 50));
    }

    private void ActivateBtn(object btnSender)
    {
      DisableActiveBtn();
      if (btnSender is Button button)
      {
        button.BackColor = Color.FromArgb(157, 178, 191);
      }
    }

    private void DisableActiveBtn()
    {
      foreach (Control btn in panelMenu.Controls)
        if (btn.GetType() == typeof(Button))
          btn.BackColor = Color.FromArgb(82, 109, 130);
    }

    private void OpenForm(Form form, object sender)
    {
      ActivateBtn(sender);
      if (activeForm == form)
        return;
      activeForm = form;
      form.TopLevel = false;
      form.FormBorderStyle = FormBorderStyle.None;
      form.Dock = DockStyle.Fill;
      this.DesktopPanel.Controls.Add(form);
      this.DesktopPanel.Tag = form;
      form.BringToFront();
      form.Show();
      //Headerlabel.Text = form.Text;

    }

    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

    private void button1_Click(object sender, EventArgs e) =>
      OpenForm(booksForm, sender);


    private void button2_Click(object sender, EventArgs e) =>
      OpenForm(categoriesForm, sender);

    private void button3_Click(object sender, EventArgs e) =>
      OpenForm(ordersForm, sender);

    private void button4_Click(object sender, EventArgs e) =>
      OpenForm(cartForm, sender);

    private void prevBtn_Click(object sender, EventArgs e)
    {
      pageNum--;
      if (pageNum == 1)
      {
        prevBtn.Visible = false;
        nextBtn.Visible = true;
      }
      else if (pageNum == maxPageNum) 
      {
        prevBtn.Visible = true;
        nextBtn.Visible = false;
      }
      else
      {
        prevBtn.Visible = true;
        nextBtn.Visible = true;
      }

      booksForm = new BooksForm(BookService.GetAllPagination(10, pageNum), customer.Id);
      OpenForm(booksForm, this);

    }

    private void nextBtn_Click(object sender, EventArgs e)
    {
      pageNum++;
      if (pageNum == maxPageNum)
      {
        prevBtn.Visible = true;
        nextBtn.Visible = false;
      }
      else if(pageNum == 1)
      {
        prevBtn.Visible = false;
        nextBtn.Visible = true;
      }
      else
      {
        prevBtn.Visible = true;
        nextBtn.Visible = true;
      }

      booksForm = new BooksForm(BookService.GetAllPagination(10, pageNum), customer.Id);
      OpenForm(booksForm, this);

    }

    private void button6_Click(object sender, EventArgs e)
    {
      this.Close();
      mainForm.ShowLogin();

    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
      OpenForm(cartForm, sender);
      button4.BackColor = Color.FromArgb(157, 178, 191);
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
      OpenForm(ordersForm, sender);
      button3.BackColor = Color.FromArgb(157, 178, 191);
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      OpenForm(settingForm, sender);
      button5.BackColor = Color.FromArgb(157, 178, 191);
    }

    private void button5_Click(object sender, EventArgs e)=>
      OpenForm(settingForm, sender);
    
  }

}
