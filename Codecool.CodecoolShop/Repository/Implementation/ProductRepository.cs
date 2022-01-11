using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Repository.Implementation
{
    public class ProductRepository : IProductRepository
    {
        DbContext _coolShopContext;
        public ProductRepository(DbContext CoolShopContext)
        {
            _coolShopContext = CoolShopContext;
        }
        public void Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
