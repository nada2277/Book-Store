using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Contracts
{
  public interface ICustomerRepository : IRepository<Customer, int>
  {
    IQueryable<Order> GetCustomerOrders(int customerId);
    IQueryable<CartItem> GetCustomerCart(int customerId);
    void AddCartItem(int bookId, int customerId, int quantity);
  }
}
