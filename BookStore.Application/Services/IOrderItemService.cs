using BookStore.Models;

namespace BookStore.Application.Services
{
  public interface IOrderItemService
  {
   bool AddItem(OrderItem item);
    bool DeleteItem(int id);
  }
}