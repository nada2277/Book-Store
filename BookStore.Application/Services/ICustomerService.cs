using BookStore.Models;

namespace BookStore.Application.Services
{
  public interface ICustomerService
  {
    bool AddCustomer(Customer Customer);
    bool UpdateCustomer(Customer Customer);
    bool DeleteCustomer(Customer Customer);
    Customer GetbyId(int id);
    List<Customer> GetAllPagination(int num, int pageIndex);
    bool IsUsrNameExisit(string usrName);
    bool IsUsrEmailExisit(string usrEmail);
    bool IsUsrPhoneExisit(string phone);
    Customer IsLogin(string username, string password);
    void AddToCart(int bookId, int customerId, int quantity);
    List<Order> ShowOrders(int customerId);
    bool HasItemInCart(int customerId);
  }
}