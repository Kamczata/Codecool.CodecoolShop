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
        DbContext _coolShopContext;
        public OrderRepository(DbContext CoolShopContext)
        {
            _coolShopContext = CoolShopContext;
        }
        public void Add(Order order)
        {
            throw new NotImplementedException();
        }

        public Order Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetCustomerOrders(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
