using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;

namespace Codecool.CodecoolShop.Repository.Implementation
{
    public class ProductRepository : IProductRepository
    {
        CoolShopContext _context;
        public ProductRepository(CoolShopContext coolShopContext)
        {
            _context = coolShopContext;
        }
        public void Add(Product item)
        {
            _context.Products.Add(item);
            _context.SaveChanges();
        }

        public Product Get(int id)
        {
            return _context.Products
                .Include(p => p.Supplier)
                .FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

       /* public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }*/

        public void Remove(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _context.Products.Where(p => p.ProductCategory.Id == categoryId).ToList();
        }

        public List<Product> GetProductsBySupplier(int supplierId)
        {
            return _context.Products.Where(p => p.Supplier.Id == supplierId).ToList();
        }
    }
}
