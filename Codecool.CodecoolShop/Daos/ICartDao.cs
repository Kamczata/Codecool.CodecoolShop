using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codecool.CodecoolShop.Models;

namespace Codecool.CodecoolShop.Daos
{
    public interface ICartDao
    {
        void Add(Product product);
        void Remove(int id, int quantity);
        Cart Get();
        Dictionary<Product, int> GetItems();
        int ProductsQuantity();
        void AssignCustomer(Customer customer);

    }
}
