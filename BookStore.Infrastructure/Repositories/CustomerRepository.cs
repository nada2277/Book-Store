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
  public class CustomerRepository : Repository<Customer, int>, ICustomerRepository
  {
    BookStoreContext context;
    public CustomerRepository(BookStoreContext _bookStoreContext) : base(_bookStoreContext)
    {
      context = _bookStoreContext;
    }

    public void AddCartItem(int bookId, int customerId, int quantity)
    {
      var existingCartItem = context?.cartItems?.FirstOrDefault(c => c.BookID == bookId && c.CustomerID == customerId);

      if (existingCartItem != null)
      {
        // If the item already exists, update the quantity
        existingCartItem.Quantity += quantity;
      }
      else
      {
        // If the item doesn't exist, add it as a new cart item
        var cartItem = new CartItem
        {
          BookID = bookId,
          CustomerID = customerId,
          Quantity = quantity
        };
        context.cartItems.Add(cartItem);
      }

      context.SaveChanges();
    }

    

    public IQueryable<Order> GetCustomerOrders(int customerId)
    {
      var customerOrders = context?.orders?.Where(o => o.CustomerID == customerId);

      return customerOrders;
    }

    public bool HasItemInCart(int customerId)=>
      context.cartItems.Any(c=>c.CustomerID == customerId);
  }
}
