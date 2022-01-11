using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Repository.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        DbContext _coolShopContext;
        public CustomerRepository(DbContext CoolShopContext)
        {
            _coolShopContext = CoolShopContext;
        }
        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
