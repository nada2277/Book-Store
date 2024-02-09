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
  //Book-Order many to many

  public class OrderItemService : IOrderItemService
  {
    IOrderItemRepository _OrderItemRepository { get; set; }
    public OrderItemService(IOrderItemRepository orderItemRepository)=>
      _OrderItemRepository = orderItemRepository;
    

    public bool AddItem(OrderItem item)
    {
      bool isAdded = _OrderItemRepository.Create(item);
      if (isAdded)
        _OrderItemRepository.Save();
      return isAdded;
    }
    public bool DeleteItem(OrderItem item)
    {
      bool isDeleted = _OrderItemRepository.Delete(item);
      if (isDeleted)
        _OrderItemRepository.Save();
      return isDeleted;
    }
  }
}
