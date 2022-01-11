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
        DbContext _coolShopContext;
        public SupplierRepository(DbContext CoolShopContext)
        {
            _coolShopContext = CoolShopContext;
        }
        public void Add(Supplier item)
        {
            throw new NotImplementedException();
        }

        public Supplier Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Supplier> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
