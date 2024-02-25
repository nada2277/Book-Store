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
    public partial class BooksForm : Form
    {
        Autofac.IContainer connectionBook;
        IBookService BookService;
        int pageNum;
        int maxPageNum;
        public BooksForm()
        {
            InitializeComponent();
            connectionBook = AutoFag.RegisterBook();
            BookService = connectionBook.Resolve<IBookService>();

            BookService = connectionBook.Resolve<IBookService>();

            pageNum = 1;
            maxPageNum = BookService.GetCount();
            ShowBooks(BookService.GetAllPagination(26, pageNum));
        }

        void ShowButtons()
        {
            if (maxPageNum == 1 || maxPageNum == 0)
            {
                prevBtn.Visible = false;
                nextBtn.Visible = false;
            }
            else if (pageNum == 1)
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
        }

        void ShowBooks(List<Book> books)
        {
            ShowButtons();
            dataGridView1.DataSource = books;
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            pageNum--;
            ShowBooks(BookService.GetAllPagination(26, pageNum));
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            pageNum++;
            ShowBooks(BookService.GetAllPagination(26, pageNum));
        }



        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text)
               && !string.IsNullOrEmpty(textBox2.Text)
               && !string.IsNullOrEmpty(textBox3.Text)
               && !string.IsNullOrEmpty(textBox4.Text)
               && !string.IsNullOrEmpty(textBox5.Text))
            {
                Book book = new Book()
                {
                    Name = textBox1.Text,
                    Stock = int.Parse(textBox2.Text),
                    Description = textBox3.Text,
                    Price = double.Parse(textBox4.Text),
                    BookImg = textBox5.Text,
                };
                BookService.AddBook(book);
                ShowBooks(BookService.GetAllPagination(10, pageNum));
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text)
                && !string.IsNullOrEmpty(textBox2.Text)
                && !string.IsNullOrEmpty(textBox3.Text)
                && !string.IsNullOrEmpty(textBox4.Text)
                && !string.IsNullOrEmpty(textBox5.Text))
            {

            Book book = new Book()
            {
                Id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()),
                Name = textBox1.Text,
                Stock = int.Parse(textBox2.Text),
                Description = textBox3.Text,
                Price = double.Parse(textBox4.Text),
                BookImg = textBox5.Text,
            };
            BookService.UpdateBook(book);
            ShowBooks(BookService.GetAllPagination(10, pageNum));
            }
        }

        private void getOne_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
            textBox4.Text = row.Cells[4].Value.ToString();
            textBox5.Text = row.Cells[5].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int Id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            BookService.DeleteBook(Id);
            ShowBooks(BookService.GetAllPagination(10, pageNum));
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
