using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitechSupportManagement.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get(Func<T, bool> filter);
        IEnumerable<T> GetAll();
        void Add(T entity);
    }
}
