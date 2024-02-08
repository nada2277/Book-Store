using BookStore.Models;

namespace BookStore.Application.Services
{
  public interface IBookCategoryService
  {
    bool AddBookCategory(BookCategory BookCategory);
    bool UpdateBookCategory(BookCategory BookCategory);
    List<Book> GetAllBookByCategory(int id);
    bool DeleteBookCategory(int id);
  }
}