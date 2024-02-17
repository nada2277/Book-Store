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
using static System.Reflection.Metadata.BlobBuilder;

namespace BookStore.User.Forms
{
  public partial class SearchForm : Form
  {
    Autofac.IContainer connectionBook;
    IBookService BookService;
    int customerId;
    int pageNum;
    int maxPageNum;
    string name;
    public SearchForm(int id,string str)
    {
      connectionBook = AutoFag.RegisterBook();
      BookService = connectionBook.Resolve<IBookService>();

      InitializeComponent();
      name = str;
      label1.Text = name;
      customerId = id;
      pageNum = 1;
      maxPageNum =BookService.GetSearchCount(name);

      ShowButtons();
      ShowBooks(BookService.GetBooksByName(str, 10, 1));
      
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
      if (maxPageNum == 1)
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
      ShowBooks(BookService.GetBooksByName(name, 10, pageNum));
    }

    private void nextBtn_Click(object sender, EventArgs e)
    {
      pageNum++;
      ShowButtons();
      ShowBooks(BookService.GetBooksByName(name, 10, pageNum));
    }
  }
}
