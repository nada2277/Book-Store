using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderedAt { get; set; }
        public DateTime ArrivedOn { get; set; }


        //Customer-Order one to many
        public int CustomerID { get; set; }

        public Customer? Customer { get; set; }


        //Book-Order many to many
        public List<OrderItem>? OrderItems { get; set; }


    }
}
