using BookStore.Application.Contracts;
using BookStore.Context;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category, int>, ICategoryRepository
    {
        BookStoreContext context;
        public CategoryRepository(BookStoreContext _bookStoreContext) : base(_bookStoreContext)
        {
            context = _bookStoreContext;
        }


    }
}
