


namespace BookStore.User.Forms
{
  public partial class HomeForm : Form
  {
    private Form activeForm = new Form();
    private BooksForm booksForm = new BooksForm();
    private CartForm cartForm = new CartForm();
    private OrdersForm ordersForm = new OrdersForm();
    private CategoriesForm categoriesForm = new CategoriesForm();

    public HomeForm()
    {
      InitializeComponent();
      System.Drawing.Drawing2D.GraphicsPath graphicsPath = new();
      graphicsPath.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
      Region region = new Region(graphicsPath);
      pictureBox1.Region = region;
      OpenForm(booksForm, this);
    }

    private void ActivateBtn(object btnSender)
    {
      if (btnSender is Button button)
      {
        DisableActiveBtn();
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
      if (activeForm == form)
        return;
      ActivateBtn(sender);
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

    private void button1_Click(object sender, EventArgs e) =>
      OpenForm(booksForm, sender);


    private void button2_Click(object sender, EventArgs e) =>
      OpenForm(categoriesForm, sender);

    private void button3_Click(object sender, EventArgs e) =>
      OpenForm(ordersForm, sender);

    private void button4_Click(object sender, EventArgs e) =>
      OpenForm(cartForm, sender);

  }

}
