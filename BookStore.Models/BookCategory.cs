using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    //Book-Category many to many

    public class BookCategory
    {
        [Key]
        public int Id { get; set; }
        public int BookID { get; set; }
        public int CategoryID { get; set; }



        public Book? Book { get; set; }
        public Category? Category { get; set; }

    }
}
