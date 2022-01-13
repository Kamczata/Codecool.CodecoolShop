using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Repository.Implementation
{
    public class SupplierRepository : ISupplierRepository
    {
        CoolShopContext _context;
        public SupplierRepository(CoolShopContext coolShopContext)
        {
            _context = coolShopContext;
        }
        public void Add(Supplier item)
        {
            _context.Suppliers.Add(item);
            _context.SaveChanges();
        }

        public Supplier Get(int id)
        {
            return _context.Suppliers.Find(id);
        }

        public IEnumerable<Supplier> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public void Remove(int id)
        {
            var supplier = Get(id);
            _context.Suppliers.Remove(supplier);
            _context.SaveChanges();
        }
    }
}
