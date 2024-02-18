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

namespace BookStore.User.Forms
{
    public partial class OneCategoryForm : Form
    {
        Autofac.IContainer container;
        IBookService bookService;
        int pageNum;
        int maxPageNum=1;
        string currentCategory;
        int customerId;
        public OneCategoryForm(int Id,string selectedCategory)
        {
            container = AutoFag.RegisterBook();
            bookService = container.Resolve<IBookService>();

            InitializeComponent();

            currentCategory = selectedCategory;

            label1.Text = currentCategory;
            customerId = Id;
            pageNum = 1;
            maxPageNum = bookService.GetCountByCategory(currentCategory);
            ShowBooks(bookService.GetByCategoryName(currentCategory,10,pageNum));
            ShowButtons();
        }



        void ShowBooks(List<Book> books)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var book in books)
            {
                var bookControl = new BookControl(customerId);
                bookControl.BookName = book.Name;
                bookControl.BookPrice = book.Price.ToString() + " LE";
                bookControl.BookImage = Image.FromFile(Path.GetFullPath($"..\\..\\..\\Images\\{book.BookImg}"));
                bookControl.id = book.Id;
                flowLayoutPanel1.Controls.Add(bookControl);
            }
        }

        void ShowButtons()
        {
            if (maxPageNum == 1|| maxPageNum == 0)
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

        private void prevBtn_Click(object sender, EventArgs e)
        {
            pageNum--;
            ShowButtons();
            ShowBooks(bookService.GetByCategoryName(currentCategory, 10, pageNum));

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            pageNum++;
            ShowButtons();
            ShowBooks(bookService.GetByCategoryName(currentCategory, 10, pageNum));

        }

        private void OneCategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}