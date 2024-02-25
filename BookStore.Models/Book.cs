using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public string BookImg { get; set; }




        //Book-Order many to many
        public List<OrderItem>? OrderItems { get; set; }


        //Customer-Book many to many
        public List<CartItem>? CartItems { get; set; }


        //Book-Category many to many
        public List<BookCategory>? BookCategories { get; set; }


    }
}
