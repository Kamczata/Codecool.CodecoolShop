using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Repository.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        DbContext _coolShopContext;
        public CategoryRepository(DbContext CoolShopContext)
        {
            _coolShopContext = CoolShopContext;
        }
        public void Add(ProductCategory item)
        {
            throw new NotImplementedException();
        }

        public ProductCategory Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
