using Data;
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
        CoolShopContext _context;
        public CategoryRepository(CoolShopContext coolShopContext)
        {
            _context = coolShopContext;
        }
        public void Add(ProductCategory item)
        {
            _context.Categories.Add(item);
            _context.SaveChanges();
        }

        public ProductCategory Get(int id)
        {
            return _context.Categories.Find(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _context.Categories.ToList();
        }

        public void Remove(int id)
        {
            var item = _context.Categories.Find(id);
            _context.Categories.Remove(item);
            _context.SaveChanges();
        }
    }
}
