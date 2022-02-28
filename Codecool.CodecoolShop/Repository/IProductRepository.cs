using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Repository
{
    public interface IProductRepository: IRepository<Product>
    {
        public List<Product> GetAll2();

        public List<Product> GetProductsByCategory(int categoryId);

        public List<Product> GetProductsBySupplier(int supplierId);
    }
}
