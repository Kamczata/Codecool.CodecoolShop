using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        CoolShopContext _context;
        public OrderRepository(CoolShopContext coolShopContext)
        {
            _context = coolShopContext;
        }
        public void Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public Order Get(int id)
        {
            return _context.Orders.Find(id);
        }

        public IEnumerable<Order> GetCustomerOrders(int customerId)
        {
            return _context.Orders.Where(o => o.Customer.Id == customerId).ToList();
        }

        public void Increase(int productId, int orderId)
        {
            _context.SaveChanges();

        }

        public void Decrease(int productId, int orderId)
        {
            
        }

        public void Remove(int productId, int orderId)
        {
            _context.SaveChanges();
        }
    }
}
