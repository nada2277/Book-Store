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



        public bool ChangeStatus( Order order)
        {
            TimeSpan timeSinceOrder = DateTime.Now - order.OrderedAt;

            //// If the current time is within 2 minutes of the order time, set status to "Placed"
            //if (/*order.Status == OrderStatus.Placed.ToString() &&*/ timeSinceOrder <= TimeSpan.FromMinutes(2))
            //{
            //    order.Status = OrderStatus.Placed.ToString();
            //    context.SaveChanges();
            //    return true;
            //}

            // If 2 hours have passed, set status to "Confirmed"
            if (order.Status == OrderStatus.Placed.ToString() && timeSinceOrder >= TimeSpan.FromHours(2))
            {
                order.Status = OrderStatus.Confirm.ToString();
                context.SaveChanges();

                return true;
            }

            // If 1 day has passed, set status to "Shipped"
            if (order.Status == OrderStatus.Confirm.ToString() &&timeSinceOrder >= TimeSpan.FromDays(1))
            {
                order.Status = OrderStatus.Shipped.ToString();

                context.SaveChanges();

                return true;
            }

            // If 2 days have passed, set status to "Delivered"
            if (order.Status == OrderStatus.Shipped.ToString() && timeSinceOrder >= TimeSpan.FromDays(2))
            {
                order.Status = OrderStatus.Delivered.ToString();
                order.ArrivedOn = DateTime.Now;
                context.SaveChanges();

                return true;
            }

            //// If the order is canceled, set status to "Canceled"
            //if (order.Status == OrderStatus.Canceled.ToString())
            //{
            //    order.Status = OrderStatus.Canceled.ToString();
            //    context.SaveChanges();

            //    return true;
            //}

            //// If the order is returned, set status to "Returned"
            //if (order.Status == OrderStatus.Return.ToString())
            //{
            //    order.Status = OrderStatus.Return.ToString();
            //    context.SaveChanges();

            //    return true;
            //}
            
            return false; 
        }


    }


}


