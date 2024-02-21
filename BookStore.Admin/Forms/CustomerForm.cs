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
    public partial class CustomerForm : Form
    {
        Autofac.IContainer connectionCustomer;
        ICustomerService CustomerService;
        int pageNum;
        int maxPageNum;

        public CustomerForm()
        {
            InitializeComponent();
            connectionCustomer = AutoFag.RegisterCustomer();
            CustomerService = connectionCustomer.Resolve<ICustomerService>();

            CustomerService = connectionCustomer.Resolve<ICustomerService>();

            pageNum = 1;
            maxPageNum = 1;
            ShowCustomers(CustomerService.GetAllPagination(10, pageNum));
        }

        void ShowButtons()
        {
            if (maxPageNum == 1 || maxPageNum == 0)
            {
                button5.Visible = false;
                button6.Visible = false;
            }
            else if (pageNum == 1)
            {
                button5.Visible = false;
                button6.Visible = true;
            }
            else if (pageNum == maxPageNum)
            {
                button5.Visible = true;
                button6.Visible = false;
            }
            else
            {
                button5.Visible = true;
                button6.Visible = true;
            }
        }

        void ShowCustomers(List<Customer> Customers)
        {
            ShowButtons();
            dataGridView1.DataSource = Customers;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pageNum++;
            ShowCustomers(CustomerService.GetAllPagination(10, pageNum));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pageNum--;
            ShowCustomers(CustomerService.GetAllPagination(10, pageNum));
        }


        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            Customer Customers = new Customer()
            {
                //Id = int.Parse(textBox1.Text),
                FirstName = (textBox2.Text),
                LastName = textBox3.Text,
                Address = textBox4.Text,
                Phone = textBox5.Text,
                Password = textBox6.Text,
                UserName = textBox7.Text,
                Email = textBox8.Text,
                ProfilePic = textBox9.Text,
                //IsAdmin = bool.Parse(textBox10.Text),
            };
            CustomerService.AddCustomer(Customers);
            ShowCustomers(CustomerService.GetAllPagination(10, pageNum));
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Customer Customers = new Customer()
            {
                Id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()),
                FirstName = (textBox2.Text),
                LastName = textBox3.Text,
                Address = textBox4.Text,
                Phone = textBox5.Text,
                Password = textBox6.Text,
                UserName = textBox7.Text,
                Email = textBox8.Text,
                ProfilePic = textBox9.Text,
                //IsAdmin = bool.Parse(textBox10.Text),
            };
            CustomerService.UpdateCustomer(Customers);
            ShowCustomers(CustomerService.GetAllPagination(10, pageNum));
        }

        private void GetOne_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox6.Text = row.Cells[5].Value.ToString();
            textBox7.Text = row.Cells[6].Value.ToString();
            textBox8.Text = row.Cells[7].Value.ToString();
            textBox9.Text = row.Cells[8].Value.ToString();
            textBox10.Text = row.Cells[9].Value.ToString();


        }

        private void DeleteClick(object sender, EventArgs e)
        {
            int Id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            CustomerService.DeleteCustomer(Id);
            ShowCustomers(CustomerService.GetAllPagination(10, pageNum));
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
