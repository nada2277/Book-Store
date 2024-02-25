using BookStore.Models;

namespace BookStore.Application.Contracts
{
    public interface ICategoryRepository : IRepository<Category, int>
  {
  }
}
