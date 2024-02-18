using Autofac;
using BookStore.Application.Services;
using BookStore.Models;
using System.Runtime.InteropServices;
using Test.Presentation.AutoFag;


namespace BookStore.User.Forms
{
    public partial class HomeForm : Form
    {
        Form activeForm = new Form();
        BooksForm booksForm;
        CartForm cartForm;
        EmptyCart emptyCart;
        OrderPlacedForm orderPlacedForm;
        OrdersForm ordersForm = new OrdersForm();
        CategoriesForm categoriesForm;
        OneCategoryForm oneCategoryForm;
        Customer customer;
        SettingForm settingForm;
        Form1 mainForm;
        IContainer connectionCustomer;
        ICustomerService CustomerService;
        public HomeForm(Customer _customer, Form1 form)
        {
            InitializeComponent();

            connectionCustomer = AutoFag.RegisterCustomer();
            CustomerService = connectionCustomer.Resolve<ICustomerService>();

            mainForm = form;
            customer = _customer;

            settingForm = new SettingForm(customer , this);
            orderPlacedForm = new OrderPlacedForm(this);

            booksForm = new BooksForm(customer.Id);
            emptyCart = new EmptyCart(this);
            categoriesForm = new CategoriesForm(this);

            OpenForm(booksForm, this);
            #region Header
            fnameLabel.Text = customer.FirstName[0].ToString().ToUpper() + customer.FirstName[1..];
            pictureBox1.BackgroundImage = Image.FromFile(Path.GetFullPath($"..\\..\\..\\Images\\{customer.ProfilePic}"));
            //pictureBox1.BackgroundImage = Image.FromFile(Path.GetFullPath(customer.ProfilePic));

            if (!customer.ProfilePic.Equals("profilePicture.png"))
                pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            //round Img
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new();
            graphicsPath.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
            Region region = new Region(graphicsPath);
            pictureBox1.Region = region;
            searchPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, searchPanel.Width, searchPanel.Height, 50, 50));
            #endregion
            button1.BackColor = Color.FromArgb(157, 178, 191);
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
        }

        public void ShowBooks()
        {
            OpenForm(booksForm, this);
            button1.BackColor = Color.FromArgb(157, 178, 191);

        }

        public void ShowEmptyCart()
        {
            OpenForm(emptyCart, this);
            button4.BackColor = Color.FromArgb(157, 178, 191);


        }
        public void ShowCat(string str)
        {
            oneCategoryForm = new OneCategoryForm(customer.Id, str);
            OpenForm(oneCategoryForm, this);
            button2.BackColor = Color.FromArgb(157, 178, 191);

        }
        public void ShowOrderPlaced()
        {
            OpenForm(orderPlacedForm, this);
            button4.BackColor = Color.FromArgb(157, 178, 191);
        }

        public void UpdateProfilePicture(string profilePicPath)
        {
            pictureBox1.BackgroundImage = Image.FromFile(Path.GetFullPath($"..\\..\\..\\Images\\{profilePicPath}"));
            if (!profilePicPath.Equals("profilePicture.png"))
                pictureBox1.BackColor = Color.Transparent;
        }

        #region Events
        private void button1_Click(object sender, EventArgs e) =>
         OpenForm(booksForm, sender);

        private void button2_Click(object sender, EventArgs e) =>
          OpenForm(categoriesForm, sender);

        private void button3_Click(object sender, EventArgs e) =>
          OpenForm(ordersForm, sender);

        private void button4_Click(object sender, EventArgs e)
        {
            if (CustomerService.HasItemInCart(customer.Id))
            {
                cartForm = new CartForm(customer, this);
                OpenForm(cartForm, sender);
            }
            else
                OpenForm(emptyCart, this);
            button4.BackColor = Color.FromArgb(157, 178, 191);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.ShowLogin();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (CustomerService.HasItemInCart(customer.Id))
            {
                cartForm = new CartForm(customer, this);
                OpenForm(cartForm, sender);
            }
            else
                OpenForm(emptyCart, this);
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

        private void button5_Click(object sender, EventArgs e) =>
          OpenForm(settingForm, sender);

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
                return;
            SearchForm SearchForm = new SearchForm(customer.Id, textBoxSearch.Text);
            OpenForm(SearchForm, sender);
        }

        #endregion

        #region Rounded Button
        //Rounded Button
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
        #endregion

    }

}
