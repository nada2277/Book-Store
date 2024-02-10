

using Autofac;
using BookStore.Application.Services;
using BookStore.Context;
using BookStore.Infrastructure.Repositories;
using BookStore.Models;
using Test.Presentation.AutoFag;



internal class Program
{
  private static void Main(string[] args)
  {
    #region Autofag Connectio
    var connectionBook = AutoFag.RegisterBook();
    var connectionBookCategory = AutoFag.RegisterBookCategory();
    var connectionCartItem = AutoFag.RegisterCartItem();
    var connectionCategory = AutoFag.RegisterCategory();
    var connectionCustomer = AutoFag.RegisterCustomer();
    var connectionOrder = AutoFag.RegisterOrder();
    var connectionOrderItem = AutoFag.RegisterOrderItem();



    IBookService BookService = connectionBook.Resolve<IBookService>();
    IBookCategoryService BookCategoryService = connectionBookCategory.Resolve<IBookCategoryService>();
    ICartItemService CartItemService = connectionCartItem.Resolve<ICartItemService>();
    ICategoryService CategoryService = connectionCategory.Resolve<ICategoryService>();
    ICustomerService CustomerService = connectionCustomer.Resolve<ICustomerService>();
    IOrderService OrderService = connectionOrder.Resolve<IOrderService>();
    IOrderItemService OrderItemService = connectionOrderItem.Resolve<IOrderItemService>();


    #endregion



    Order c = new Order()
    {
      Status = "Pending",
      Address = "ss",
      TotalPrice = 200,
      OrderedAt = DateTime.Now,
      ArrivedOn = DateTime.Now,
      CustomerID = 2,

    };

    Customer c2 = new Customer()
    {
      FirstName = "mohamed",
      LastName = "saeed",
      Address = "sds",
      Phone = "sds",
      Password = "212",
      UserName = "sds",
      Email = "jlkj"
    };

    //CustomerService.AddCustomer(c2);
    //OrderService.AddOrder(c);

    var StudentFROMget = CustomerService.GetAllPagination(10, 1);
    foreach (var item in StudentFROMget)
    {
      Console.WriteLine($"Student Name From GetAllPagination: {item.FirstName}");
      Console.WriteLine($"Orders:");

      foreach (var item2 in CustomerService.ShowOrders(item.Id))
        Console.WriteLine($"\tStudent Name From GetAllPagination: {item2.Status}");
      Console.WriteLine("---------------------------");
    }

    //var orsers = OrderService.GetAllPagination(10,1);
    //foreach (var item in orsers)
    //  Console.WriteLine($"\nStudent Name From GetAllPagination: {item.Status}");

  }
}


