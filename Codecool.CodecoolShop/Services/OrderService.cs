using Codecool.CodecoolShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Services
{
    public class OrderService
    {
        private readonly IOrderRepository orderRepository;
        //private readonly ICustomerRepository customerRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
    }
}
