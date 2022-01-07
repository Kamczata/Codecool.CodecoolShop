using Codecool.CodecoolShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Daos.Implementations
{
    public class CustomerDaoMemory : ICustomerDao
    {
        private Customer data = new Customer();
        private static CustomerDaoMemory instance = null;

        private CustomerDaoMemory()
        {
        }

        public static CustomerDaoMemory GetInstance()
        {
            if (instance == null)
            {
                instance = new CustomerDaoMemory();
            }

            return instance;
        }
        public Customer Get()
        {
            return data;
        }
    }
}
