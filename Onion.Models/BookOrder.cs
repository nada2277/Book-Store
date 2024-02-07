using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Models
{
    //Book-Order many to many

    public class BookOrder
    {
        [Key]
        public int Id { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int BookID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
