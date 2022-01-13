using Data;
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
        CoolShopContext _context;
        public CustomerRepository(CoolShopContext coolShopContext)
        {
            _context = coolShopContext;
        }
        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public Customer Get(int id)
        {
            return _context.Customers.Find(id);
        }

        public void Remove(int id)
        {
            var item = Get(id);
            _context.Customers.Remove(item);
            _context.SaveChanges();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
