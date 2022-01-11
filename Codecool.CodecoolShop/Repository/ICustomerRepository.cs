using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Repository
{
    public interface ICustomerRepository
    {
        public Customer Get(int id);
        public void Add(Customer customer);
        public void Update(int id);
        public void Remove(int id);

    }
}
