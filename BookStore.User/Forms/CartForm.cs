using Autofac;
using BookStore.Application.Services;
using BookStore.DTOs;
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
    public partial class CartForm : Form
    {
        Autofac.IContainer connectionCartItem;
        ICartItemService CartItemService;
        Customer customer;
        double totalPrice;
        HomeForm homeForm;
        public CartForm(Customer customer, HomeForm form)
        {
            homeForm = form;
            totalPrice = 0;
            connectionCartItem = AutoFag.RegisterCartItem();
            CartItemService = connectionCartItem.Resolve<ICartItemService>();
            this.customer = customer;
            InitializeComponent();
            AddItems(CartItemService.BookCartItems(customer.Id));

        }
        public void UpdateCart()
        {
            AddItems(CartItemService.BookCartItems(customer.Id));
        }
        void AddItems(List<BookCart> cart)
        {
            if (cart.Count == 0)
            {
                homeForm.ShowEmptyCart();
                this.Close();

                return;
            }
            cartItemPanel.Controls.Clear();
            totalPrice = 0;
            foreach (var item in cart)
            {
                var itemControl = new CartItemControler(this);
                itemControl.Title = item.Title;
                totalPrice += item.Price * item.Quantity;
                itemControl.BookPrice = (item.Price * item.Quantity) + " LE";
                itemControl.BookId = item.BookId;
                itemControl.CartId = item.CartItemId;
                itemControl.Quantity = item.Quantity.ToString();
                itemControl.Stock = item.Stock;
                itemControl.BookImage = Image.FromFile(Path.GetFullPath($"..\\..\\..\\Images\\{item.Image}"));
                cartItemPanel.Controls.Add(itemControl);
            }
            totalPriceLabel.Text = totalPrice.ToString() + " LE";
            subTotal.Text = totalPrice.ToString() + " LE";
        }

        private void button1_Click(object sender, EventArgs e) =>
          homeForm.ShowBooks();

        private void button2_Click(object sender, EventArgs e)
        {
            CartItemService.PlaceOrder(customer.Id, customer.Address, totalPrice);
            homeForm.ShowOrderPlaced();
        }
    }
}
