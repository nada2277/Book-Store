using BookStore.Models;

namespace BookStore.Application.Services
{
  public interface IOrderService
  {
    bool AddOrder(Order order);
    List<Order> GetCustomerOrders();
    Order GetOrderById(int id);
    bool ChangeOrderStutus (Order order);




  }
}