using BookStore.Application.Services;
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
using Autofac;
using BookStore.Models;

namespace BookStore.User.Forms
{
    public partial class OrdersForm : Form
    {
        Autofac.IContainer connectionCustomer;
        ICustomerService CustomerService;
        public OrdersForm(int id)
        {
            InitializeComponent();
            connectionCustomer = AutoFag.RegisterCustomer();
            CustomerService = connectionCustomer.Resolve<ICustomerService>();
            List<Order> orders = CustomerService.ShowOrders(id);
            foreach (Order order in orders)
            {
                OrderControl control = new OrderControl();
                control.OrderId ="#"+order.Id.ToString();
                control.OrderStatus=order.Status;
                control.Address=order.Address;
                control.OrderedAt=order.OrderedAt.ToString("dd/MM/yyyy");
                control.ArrivedOn=order.ArrivedOn?.ToString("dd/MM/yyyy")?? " ";
                control.Price=order.TotalPrice.ToString()+" LE";
                flowLayoutPanel1.Controls.Add(control);
            }
        }
    }
}
