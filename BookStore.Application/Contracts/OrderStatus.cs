using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Contracts
{
  public enum OrderStatus
  {
    Placed,
    Confirm,
    Shipped,
    Delivered,
    Caneled,
    Return
  }
}
