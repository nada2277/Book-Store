using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services
{
  public interface IBookService
  {
    List<Book> GetAllPagination(int num, int pageIndex);
    Book GetBookById(int id);
    bool AddBook(Book book);
    bool UpdateBook(Book book);
    bool DeleteBook(Book book);
    List<Book> GetByCategoryName(string name);
    List<Book> GetBooksByName(string name);

    int GetCount();


  }
}
