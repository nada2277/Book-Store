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

    public OrderService(IOrederRepository orderRepository) => _OrderRepository = orderRepository;
    public bool AddOrder(Order order)
    {
      bool isAdded = _OrderRepository.Create(order);
      if (isAdded)
        _OrderRepository.Save();
      return isAdded;
    }

    public void ChangeOrderStutus(int orderId, OrderStatus status)=>
      _OrderRepository.GetById(orderId).Status=status.ToString();
    

    public Order GetOrderById(int id)=>_OrderRepository.GetById(id);
    
    
  }
}
