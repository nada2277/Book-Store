using BookStore.Models;

namespace BookStore.Application.Services
{
  public interface ICartItemService
  {
    bool AddCartItem(CartItem CartItem);
    bool UpdateCartItem(CartItem CartItem);
    bool DeleteCartItem(CartItem CartItem);
    bool ChangeItemQuantity(CartItem CartItem,int quantity);

  }
}