using Codecool.CodecoolShop.Repository;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Services
{
    public class CartService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IProductRepository productRepository;
        //private readonly ICustomerRepository customerRepository;
        public CartService(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
        }
        public Product GetProductById(int id)
        {
            return this.productRepository.Get(id);
        }
    }
}
