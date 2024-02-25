using Autofac;
using BookStore.Application.Services;

namespace BookStore.User.Forms
{
    public partial class CartItemControler : UserControl
    {
        public string Title { get => label1.Text; set => label1.Text = value; }
        public string BookPrice { get => label2.Text; set => label2.Text = value; }
        public int CartId { get; set; }
        public int BookId { get; set; }
        public int Stock { get; set; }
        public string Quantity { get => quantity.Text; set => quantity.Text = value; }
        public Image BookImage { get => pictureBox1?.BackgroundImage; set => pictureBox1.BackgroundImage = value; }

        Autofac.IContainer connectionCartItem;
        ICartItemService CartItemService;
        CartForm cartform;
        public CartItemControler(CartForm cartform)
        {
            connectionCartItem = AutoFag.RegisterCartItem();
            CartItemService = connectionCartItem.Resolve<ICartItemService>();
            InitializeComponent();
            this.cartform = cartform;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newQuantity = int.Parse(Quantity) + 1;
            if (newQuantity <= Stock)
            {
                Quantity = newQuantity.ToString();
                CartItemService.ChangeItemQuantity(CartId, newQuantity);
                cartform.ShowCartItems();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int newQuantity = int.Parse(Quantity) - 1;

            Quantity = newQuantity.ToString();
            CartItemService.ChangeItemQuantity(CartId, newQuantity);
            cartform.ShowCartItems();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int newQuantity = 0;

            Quantity = newQuantity.ToString();
            CartItemService.ChangeItemQuantity(CartId, newQuantity);
            cartform.ShowCartItems();
        }
    }
}
