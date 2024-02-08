using BookStore.Models;

namespace BookStore.Application.Services
{
  public interface IBookCategoryService
  {
    bool AddBookCategory(BookCategory BookCategory);
    bool UpdateBookCategory(BookCategory BookCategory);
    bool DeleteBookCategory(int id);
  }
}