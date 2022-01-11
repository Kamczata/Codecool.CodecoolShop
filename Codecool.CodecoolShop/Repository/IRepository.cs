using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Repository
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(int id);
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
