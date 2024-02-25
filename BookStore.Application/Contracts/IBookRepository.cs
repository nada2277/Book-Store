using BookStore.Models;

namespace BookStore.Application.Contracts
{
    public interface IBookRepository : IRepository<Book, int>
    {
        IQueryable<Book> SearchName(string name);
        IQueryable<Book> GetByCategory(string name);
        bool ChangeStockQuantity(Book book, int quantity);
        bool CheckStockQuantity(Book book);
        int GetCountByCategory(string name);
    }
}
