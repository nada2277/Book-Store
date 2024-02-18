using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTOs
{
  public class BookCart
  {
    public int BookId { get; set; }
    public int CartItemId { get; set; }
    public int Quantity { get; set; }
    public int Stock { get; set; }
    public string Title { get; set; }
    public string Image { get; set; }
    public double Price { get; set; }

  }
}
