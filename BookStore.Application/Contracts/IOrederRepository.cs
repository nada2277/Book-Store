using BookStore.Models;

namespace BookStore.Application.Contracts
{
    public interface IOrederRepository : IRepository<Order, int>
  {
    bool ChangeStatus( Order order);


  }
}
