using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Context
{
    public class BookStoreContext : DbContext
    {

        public DbSet<Book>? books { get; set; }
        public DbSet<BookCategory>? bookCategorys { get; set; }
        public DbSet<CartItem>? cartItems { get; set; }
        public DbSet<Category>? categories { get; set; }
        public DbSet<Customer>? customers { get; set; }
        public DbSet<Order>? orders { get; set; }
        public DbSet<OrderItem>? orderItems { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BookStore;Integrated Security=True;TrustServerCertificate=True");

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Specify unique constraint for UserName
            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.UserName)
                .IsUnique();

            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Phone)
                .IsUnique();

            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Email)
                .IsUnique();

        }


    }
}
