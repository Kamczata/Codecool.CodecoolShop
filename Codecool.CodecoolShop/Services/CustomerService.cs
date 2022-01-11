using Codecool.CodecoolShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
    }
}
