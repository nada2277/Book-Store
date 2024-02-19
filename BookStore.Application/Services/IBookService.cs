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
        bool DeleteBook(int bookId);
        List<Book> GetByCategoryName(string name, int num, int pageIndex);
        List<Book> GetBooksByName(string name, int num, int pageIndex);

        int GetCount();
        int GetCountByCategory(string name);
      int GetSearchCount(string name);

    }
}
