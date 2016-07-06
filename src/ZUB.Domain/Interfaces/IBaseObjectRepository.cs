using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZUB.Domain
{
    public interface IBaseObjectRepository<T> where T:BaseObject
    {
        T GetById(int id);
        IEnumerable<T> GetByName(string name);
        IEnumerable<T> GetAll();
    }
}
