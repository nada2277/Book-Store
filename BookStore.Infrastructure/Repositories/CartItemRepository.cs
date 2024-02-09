using BookStore.Application.Contracts;
using BookStore.Context;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.Repositories
{
    public class CartItemRepository : Repository<CartItem, int>, ICartItemRepository
    {
        BookStoreContext context;
        public CartItemRepository(BookStoreContext _bookStoreContext) : base(_bookStoreContext)
        {
            context = _bookStoreContext;
        }

        public bool ChangeQuantity(CartItem cartItem, int quantity)
        {
            if (cartItem == null)
                return false;

            // Retrieve the associated book
            var book = context.books.FirstOrDefault(b => b.Id == cartItem.BookID);
            if (book == null)
                return false; 

            // Calculate the new quantity after adding the provided quantity
            int newQuantity = cartItem.Quantity + quantity;

            // Ensure the resulting quantity is not negative and does not exceed available stock
            if (newQuantity < 0 || newQuantity > book.Stock)
                return false; 

            // Update the quantity of the cart item
            cartItem.Quantity = newQuantity;

            context.SaveChanges();

            return true; 
        }
    }
}
