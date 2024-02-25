using BookStore.Application.Contracts;
using BookStore.Models;

namespace BookStore.Application.Services
{

    public class BookCategoryService : IBookCategoryService
  {
    IBookCategoryRepository _BookCategoryRepository { get; set; }

    public BookCategoryService(IBookCategoryRepository bookCategoryService)=>
      _BookCategoryRepository= bookCategoryService;
    public bool AddBookCategory(BookCategory BookCategory)
    {
      bool isAdded = _BookCategoryRepository.Create(BookCategory);
      if (isAdded)
        _BookCategoryRepository.Save();
      return isAdded;
    }

    public bool DeleteBookCategory(BookCategory BookCategory)
    {
      bool isDeleted = _BookCategoryRepository.Delete(BookCategory);
      if (isDeleted)
        _BookCategoryRepository.Save();
      return isDeleted;
    }

    public bool UpdateBookCategory(BookCategory BookCategory)
    {
      bool isUpdated = _BookCategoryRepository.Update(BookCategory);
      if (isUpdated)
        _BookCategoryRepository.Save();
      return isUpdated;
    }

    //public List<Book> GetAllBookByCategory(int id)=>_BookCategoryRepository.GetBooksByCategory(id);
    
  }
}
