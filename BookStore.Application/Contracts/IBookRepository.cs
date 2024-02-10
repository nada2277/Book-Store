using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Contracts
{
  public interface IBookRepository : IRepository<Book, int>
  {
    IQueryable<Book> SearchName(string name);
    IQueryable<Book> GetByCategory(string name);
    bool ChangeStockQuantity(Book book,int quantity);
    bool CheckStockQuantity(Book book);

  }
}
