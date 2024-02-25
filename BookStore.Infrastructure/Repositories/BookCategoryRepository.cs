using BookStore.Application.Contracts;
using BookStore.Context;
using BookStore.Models;

namespace BookStore.Infrastructure.Repositories
{
    public class BookCategoryRepository : Repository<BookCategory, int>, IBookCategoryRepository
    {
        BookStoreContext context;
        public BookCategoryRepository(BookStoreContext _bookStoreContext) : base(_bookStoreContext)
        {
            context = _bookStoreContext;
        }

      
    }
}
