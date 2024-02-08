using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Category
    {
        [Key]

        public int Id { get; set; } 
        public string Name { get; set; }
        //Book-Category many to many
        public List<BookCategory> BookCategories { get; set; }


    }
}
