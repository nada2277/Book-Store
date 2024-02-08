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
  public class OrderService : IOrderService
  {
    IOrederRepository _OrderRepository { get; set; }

    public bool AddOrder(Order order)
    {
      throw new NotImplementedException();
    }

    public bool ChangeOrderStutus(Order order)
    {
      throw new NotImplementedException();
    }

    public List<Order> GetCustomerOrders()
    {
      throw new NotImplementedException();
    }

    public Order GetOrderById(int id)
    {
      throw new NotImplementedException();
    }
  }
}
