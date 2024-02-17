using BookStore.Application.Contracts;
using BookStore.Context;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.Repositories
{
    public class BookRepository : Repository<Book, int>, IBookRepository
    {
        BookStoreContext context;
        public BookRepository(BookStoreContext _bookStoreContext) : base(_bookStoreContext)
        {
            context = _bookStoreContext;
        }


        public bool ChangeStockQuantity(Book book, int quantity)
        {

            if (book == null)
                return false;

            // Ensure the resulting quantity is not negative
            if (book.Stock + quantity < 0)
                return false;

            // Update the stock quantity of the book
            book.Stock += quantity;

            // Save changes to persist the updated stock quantity
            context.SaveChanges();

            return true;
        }

        public bool CheckStockQuantity(Book book)
        {
            if (book == null)
                return false;

            return book.Stock > 0;
        }

        public IQueryable<Book> GetByCategory(string name)
        {
            return context.books.Where(b => b.BookCategories.Any(bc => bc.Category.Name.ToLower().Contains(name.ToLower())));
        }
        public int GetCountByCategory(string name)
        {
            return context.books.Where(b => b.BookCategories.Any(bc => bc.Category.Name.ToLower().Contains(name.ToLower()))).Count();
        }


        public IQueryable<Book> SearchName(string name)
        {
            return context.books.Where(b => b.Name.ToLower().Contains(name.ToLower()));
        }
    }
}
