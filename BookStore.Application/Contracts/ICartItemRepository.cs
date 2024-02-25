using BookStore.DTOs;
using BookStore.Models;

namespace BookStore.Application.Contracts
{
    public interface ICartItemRepository : IRepository<CartItem, int>
    {
        bool ChangeQuantity(int CartItemId, int quantity);
        public IQueryable<BookCart> GetCustomerCart(int customerId);
        void PlaceOrder(Order order);
    }
}
