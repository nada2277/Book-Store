using BookStore.Application.Contracts;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services
{
    public class OrderService : IOrderService
    {
        IOrederRepository _OrderRepository { get; set; }

        public OrderService(IOrederRepository orderRepository) => _OrderRepository = orderRepository;
        public bool AddOrder(Order order)
        {
            bool isAdded = _OrderRepository.Create(order);
            if (isAdded)
                _OrderRepository.Save();
            return isAdded;
        }

        public void ChangeOrderStutus(int orderId, OrderStatus status) =>
          _OrderRepository.GetById(orderId).Status = status.ToString();


        public Order GetOrderById(int id) => _OrderRepository.GetById(id);

        public List<Order> GetAllPagination(int num, int pageIndex)
          => _OrderRepository.GetAll().Skip(num * (pageIndex - 1)).Take(num).ToList();

        public bool DeleteOrder(int orderId)
        {
            Order order= _OrderRepository.GetById(orderId);
            bool isDeleted = _OrderRepository.Delete(order);
            if (isDeleted)
                _OrderRepository.Save();
            return isDeleted;
        }
        public void ChangeOrderStatusAuto(int orderId)
        {
            Order order = _OrderRepository.GetById(orderId);
            _OrderRepository.ChangeStatus(order);
            _OrderRepository.Save();
        }
    }
}
