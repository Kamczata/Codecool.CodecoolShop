using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Repository
{
    public interface IProductRepository: IRepository<Product>
    {
        public IEnumerable<Product> GetProductsByCategory(int categoryId);

        public IEnumerable<Product> GetProductsBySupplier(int supplierId);
    }
}
