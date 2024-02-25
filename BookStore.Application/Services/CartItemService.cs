using BookStore.Application.Contracts;
using BookStore.DTOs;
using BookStore.Models;

namespace BookStore.Application.Services
{
    public class CartItemService : ICartItemService
    {
        ICartItemRepository _CartItemRepository { get; set; }

        public CartItemService(ICartItemRepository cartItemRepository)
        {
            _CartItemRepository = cartItemRepository;
        }

        public bool AddCartItem(CartItem CartItem)
        {
            bool isAdded = _CartItemRepository.Create(CartItem);
            if (isAdded)
                _CartItemRepository.Save();
            return isAdded;
        }
        public bool ChangeItemQuantity(int CartItemid, int quantity)
        {
            bool isUpdated = _CartItemRepository.ChangeQuantity(CartItemid, quantity);
            if (isUpdated)
                _CartItemRepository.Save();
            return isUpdated;
        }

        public bool DeleteCartItem(CartItem CartItem)
        {
            bool isDeleted = _CartItemRepository.Delete(CartItem);
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

        public List<BookCart> BookCartItems(int CustomerId) =>
           _CartItemRepository.GetCustomerCart(CustomerId).ToList();

        public void PlaceOrder(int id, string Address, double totalPrice)
        {
            Order order = new Order();
            order.CustomerID = id;
            order.Address = Address;
            order.TotalPrice = totalPrice;
            order.OrderedAt = DateTime.Now;   
            order.Status = OrderStatus.Placed.ToString();
            _CartItemRepository.PlaceOrder(order);
        }


    }


}
