using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Models
{
    public class Book
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        //Book-Order many to many

        public List<BookOrder> BookOrders { get; set; }
        //Customer-Book many to many
        public List<CustomerBook> CustomerBooks { get; set; }
        //Book-Category many to many
        public List<BookCategory> BookCategories { get; set; }


    }
}
