using BookStore.Models;

namespace BookStore.Application.Services
{
  public interface ICustomerService
  {
    bool AddCustomer(Customer Customer);
    bool UpdateCustomer(Customer Customer);
    bool DeleteCustomer(int id);
    Customer GetbyId(int id);
    List<Customer> GetAllCustomer();
    bool IsUsrNameExisit(string usrName);
    bool IsUsrEmailExisit(int usrEmail);
    bool IsUsrPhoneExisit(string phone);
    bool IsLogin(string username, string password);
    void AddToCart(Book book, Customer customer,int quantity);
    List<Order> ShowOrders(int customerId);
  }
}