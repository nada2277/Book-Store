using BookStore.Models;

namespace BookStore.Application.Contracts
{
    public interface ICustomerRepository : IRepository<Customer, int>
  {
    IQueryable<Order> GetCustomerOrders(int customerId);
    void AddCartItem(int bookId, int customerId, int quantity);
    bool HasItemInCart(int customerId);
  }
}
