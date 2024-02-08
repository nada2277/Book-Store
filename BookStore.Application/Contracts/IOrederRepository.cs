using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Contracts
{
    public interface IOrederRepository : IRepository<Order, int>
  {
    bool ChangeStatus(OrderStatus status);


  }
}
