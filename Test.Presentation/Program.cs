

using Autofac;
using BookStore.Application.Services;
using BookStore.Context;
using BookStore.Infrastructure.Repositories;
using BookStore.Models;
using Test.Presentation.AutoFag;


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



//Testtttt 

//Order c = new Order()
//{
//    Status ="Pending",
//    Address="ss",
//    TotalPrice =200,
//    OrderedAt = DateTime.Now,
//    ArrivedOn = DateTime.Now,
//    CustomerID = 1,

//};

//Customer c2 = new Customer()
//{
//    FirstName="nada",
//    LastName="yoi",
//    Address="sds",
//    Phone="sds",
//    Password="212",
//    UserName="sds",
//    Email="jlkj"
    

//};

//CustomerService.AddCustomer(c2);
//OrderService.AddOrder(c);

//var StudentFROMget = BookService.GetAllPagination(0,3);
//foreach (var item in StudentFROMget)
//{
//    Console.WriteLine($"\nStudent Name From GetAllPagination: {item.Name}");
//}
