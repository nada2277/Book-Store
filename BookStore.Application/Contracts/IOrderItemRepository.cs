using BookStore.Models;

namespace BookStore.Application.Contracts
{
    public interface IOrderItemRepository : IRepository<OrderItem, int>
  {
  }
}
