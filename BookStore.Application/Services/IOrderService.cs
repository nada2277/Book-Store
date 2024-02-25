using BookStore.Models;

namespace BookStore.Application.Services
{
    public interface IOrderService
  {
    bool AddOrder(Order order);
    Order GetOrderById(int id);
    void ChangeOrderStutus (int orderId,OrderStatus status);
    void ChangeOrderStatusAuto(int orderId);
    List<Order> GetAllPagination(int num, int pageIndex);
    bool DeleteOrder(int orderId);

  }
}