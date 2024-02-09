using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Customer
    {
        [Key]

        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }



        //Customer-Order one to many
        public List<Order>? Orders { get; set; }


        //Customer-Book many to many
        public List<CartItem>? CartItems { get; set; }




    }
}
