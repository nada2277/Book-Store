using BookStore.DTOs;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Contracts
{
  public interface ICartItemRepository :IRepository<CartItem, int>
  {
    bool ChangeQuantity(int CartItemId, int quantity);
    public IQueryable<BookCart> GetCustomerCart(int customerId);
  }
}
