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
  public partial class ProductForm : Form
  {
    List<BookControl> books = new();

    public ProductForm()
    {
      InitializeComponent();
      for (int i = 0; i < 8; i++)
      {
        var book = new BookControl();
        book.BookName = "Book1";
        book.BookPrice = "320";
        book.BookImage = Image.FromFile(@"C:\Users\Mohamed\Desktop\User\User\bin\Images\book1.jpg");
        //Bitmap b = new Bitmap(book.BookImage);
        //book.BookImage = ResizeImage(b, new Size(600, 450));
        books.Add(book);
      }
      foreach (var book in books)
        flowLayoutPanel1.Controls.Add(book);
    }
  }
}
