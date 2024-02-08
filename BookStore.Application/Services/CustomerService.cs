using BookStore.Application.Contracts;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services
{
  public class CustomerService : ICustomerService
  {
    ICustomerRepository _CustomerRepository { get; set; }

    public bool AddCustomer(Customer Customer)
    {
      throw new NotImplementedException();
    }

    public void AddToCart(Book book, Customer customer, int quantity)
    {
      throw new NotImplementedException();
    }

    public bool DeleteCustomer(int id)
    {
      throw new NotImplementedException();
    }

    public List<Customer> GetAllCustomer()
    {
      throw new NotImplementedException();
    }

    public Customer GetbyId(int id)
    {
      throw new NotImplementedException();
    }

    public bool IsLogin(string username, string password)
    {
      throw new NotImplementedException();
    }

    public bool IsUsrEmailExisit(int usrEmail)
    {
      throw new NotImplementedException();
    }

    public bool IsUsrNameExisit(string usrName)
    {
      throw new NotImplementedException();
    }

    public bool IsUsrPhoneExisit(string phone)
    {
      throw new NotImplementedException();
    }

    public List<Order> ShowOrders(int customerId)
    {
      throw new NotImplementedException();
    }

    public bool UpdateCustomer(Customer Customer)
    {
      throw new NotImplementedException();
    }
  }
}
