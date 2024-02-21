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
using Test.Presentation.AutoFag;

namespace BookStore.Admin.Forms
{
    public partial class OrdersForm : Form
    {
        Autofac.IContainer connectionOrder;
        IOrderService OrderService;
        int pageNum;
        int maxPageNum;


        public OrdersForm()
        {
            InitializeComponent();
            connectionOrder = AutoFag.RegisterOrder();
            OrderService = connectionOrder.Resolve<IOrderService>();
            pageNum = 1;
            //maxPageNum = OrderService.ChangeOrderStutus();
            ShowOrder(OrderService.GetAllPagination(10, pageNum));
        }
        void ShowButtons()
        {
            if (maxPageNum == 1 || maxPageNum == 0)
            {
                //prevBtn.Visible = false;
                //nextBtn.Visible = false;
            }
            else if (pageNum == 1)
            {
                //prevBtn.Visible = false;
                //nextBtn.Visible = true;
            }
            else if (pageNum == maxPageNum)
            {
                //prevBtn.Visible = true;
                //nextBtn.Visible = false;
            }
            else
            {
                //prevBtn.Visible = true;
                //nextBtn.Visible = true;
            }
        }

        void ShowOrder(List<Order> orders)
        {
            ShowButtons();
            dataGridView1.DataSource = orders;
        }

        private void prevBtn(object sender, EventArgs e)
        {
            pageNum--;
            ShowOrder(OrderService.GetAllPagination(10, pageNum));
        }

        private void nextBtn(object sender, EventArgs e)
        {
            pageNum++;
            ShowOrder(OrderService.GetAllPagination(10, pageNum));
        }
        private void ViewAll_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            dateTimePicker1.Value = (DateTime)row.Cells[4].Value;

            dateTimePicker2.Value = (DateTime)row.Cells[5].Value;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            OrderService.DeleteOrder(Id);
            ShowOrder(OrderService.GetAllPagination(10, pageNum));
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }

      
    }
}
