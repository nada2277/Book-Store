using BookStore.Application;
using BookStore.Application.Contracts;
using BookStore.Context;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.Repositories
{
    public class OrederRepository : Repository<Order, int>, IOrederRepository
    {
        BookStoreContext context;
        public OrederRepository(BookStoreContext _bookStoreContext) : base(_bookStoreContext)
        {
            context = _bookStoreContext;
        }



        public bool ChangeStatus(OrderStatus status, Order order)
        {
            TimeSpan timeSinceOrder = DateTime.Now - order.OrderedAt;

            // If the current time is within 2 minutes of the order time, set status to "Placed"
            if (status == OrderStatus.Placed && timeSinceOrder <= TimeSpan.FromMinutes(2))
            {
                order.Status = OrderStatus.Placed.ToString();
                context.SaveChanges();
                return true;
            }

            // If 2 hours have passed, set status to "Confirmed"
            if (status == OrderStatus.Placed && timeSinceOrder >= TimeSpan.FromHours(2))
            {
                order.Status = OrderStatus.Confirm.ToString();
                context.SaveChanges();

                return true;
            }

            // If 1 day has passed, set status to "Shipped"
            if (status == OrderStatus.Confirm && timeSinceOrder >= TimeSpan.FromDays(1))
            {
                order.Status = OrderStatus.Shipped.ToString();
                context.SaveChanges();

                return true;
            }

            // If 2 days have passed, set status to "Delivered"
            if (status == OrderStatus.Shipped && timeSinceOrder >= TimeSpan.FromDays(2))
            {
                order.Status = OrderStatus.Delivered.ToString();
                context.SaveChanges();

                return true;
            }

            // If the order is canceled, set status to "Canceled"
            if (status == OrderStatus.Canceled)
            {
                order.Status = OrderStatus.Canceled.ToString();
                context.SaveChanges();

                return true;
            }

            // If the order is returned, set status to "Returned"
            if (status == OrderStatus.Return)
            {
                order.Status = OrderStatus.Return.ToString();
                context.SaveChanges();

                return true;
            }
            
            return false; 
        }


    }


}


