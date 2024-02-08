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
  public class CartItemService : ICartItemService
  {
    ICartItemRepository _CartItemRepository { get; set; }

    public bool AddCartItem(CartItem CartItem)
    {
      bool isAdded = _CartItemRepository.Create(CartItem);
      if (isAdded)
        _CartItemRepository.Save();
      return isAdded;
    }
    public bool ChangeItemQuantity(CartItem CartItem, int quantity)
    {
      bool isUpdated = _CartItemRepository.ChangeQuantity(CartItem,quantity);
      if (isUpdated)
        _CartItemRepository.Save();
      return isUpdated;
    }

    public bool DeleteCartItem(int id)
    {
      bool isDeleted = _CartItemRepository.Delete(id);
      if (isDeleted)
        _CartItemRepository.Save();
      return isDeleted;
    }

    public bool UpdateCartItem(CartItem CartItem)
    {
      bool isUpdated = _CartItemRepository.Update(CartItem);
      if (isUpdated)
        _CartItemRepository.Save();
      return isUpdated;
    }
  }


}
