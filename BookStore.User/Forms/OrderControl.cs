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
    public partial class OrderControl : UserControl
    {
        public string OrderId { get => label1.Text; set => label1.Text = value; }
        public string Address { get => label2.Text; set => label2.Text = value; }
        public string OrderStatus { get => label3.Text; set => label3.Text = value; }
        public string OrderedAt { get => label4.Text; set => label4.Text = value; }
        public string Price { get => label6.Text; set => label6.Text = value; }
        public string ArrivedOn { get => label7.Text; set => label7.Text = value; }
        public OrderControl()
        {
            InitializeComponent();
        }
    }
}
