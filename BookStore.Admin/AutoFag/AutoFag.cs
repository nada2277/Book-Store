using Autofac;
using BookStore.Application.Contracts;
using BookStore.Application.Services;
using BookStore.Context;
using BookStore.Infrastructure.Repositories;
using IContainer = Autofac.IContainer;

namespace BookStore.User.AutoFag
{
    public class AutoFag
    {
        public static IContainer RegisterBook()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BookStoreContext>().As<BookStoreContext>();
            builder.RegisterType<BookRepository>().As<IBookRepository>();
            builder.RegisterType<BookService>().As<IBookService>();


            var con = builder.Build();

            return con;
        }

        public static IContainer RegisterBookCategory()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BookStoreContext>().As<BookStoreContext>();
            builder.RegisterType<BookCategoryRepository>().As<IBookCategoryRepository>();
            builder.RegisterType<BookCategoryService>().As<IBookCategoryService>();


            var con = builder.Build();

            return con;
        }


        public static IContainer RegisterCartItem()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BookStoreContext>().As<BookStoreContext>();
            builder.RegisterType<CartItemRepository>().As<ICartItemRepository>();
            builder.RegisterType<CartItemService>().As<ICartItemService>();


            var con = builder.Build();

            return con;
        }


        public static IContainer RegisterCategory()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BookStoreContext>().As<BookStoreContext>();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();


            var con = builder.Build();

            return con;
        }

        public static IContainer RegisterCustomer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BookStoreContext>().As<BookStoreContext>();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<CustomerService>().As<ICustomerService>();


            var con = builder.Build();

            return con;
        }

        public static IContainer RegisterOrder()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BookStoreContext>().As<BookStoreContext>();
            builder.RegisterType<OrederRepository>().As<IOrederRepository>();
            builder.RegisterType<OrderService>().As<IOrderService>();


            var con = builder.Build();

            return con;
        }


        public static IContainer RegisterOrderItem()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BookStoreContext>().As<BookStoreContext>();
            builder.RegisterType<OrderItemRepository>().As<IOrderItemRepository>();
            builder.RegisterType<OrderItemService>().As<IOrderItemService>();


            var con = builder.Build();

            return con;
        }
    }

}
