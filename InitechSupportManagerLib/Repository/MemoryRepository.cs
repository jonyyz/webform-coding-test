using System;
using System.Collections.Generic;
using System.Linq;

namespace InitechSupportManagement.Repository
{
    public abstract class MemoryRepository<T> : IRepository<T>
    {
        private IEnumerable<T> _data;

        protected IEnumerable<T> Data
        {
            get
            {
                return _data;
            }
        }

        public MemoryRepository(IEnumerable<T> data = null)
        {
            if (data == null)
            {
                data = new List<T>();
            }

            _data = data;
        }

        public IEnumerable<T> Get(Func<T, bool> filter)
        {
            return _data.Where(filter);
        }

        public IEnumerable<T> GetAll()
        {
            return _data;
        }

        protected abstract void SetAutoIdentity(T entity);

        public void Add(T entity)
        {
            SetAutoIdentity(entity);
            _data = _data.Concat(new[] { entity });
        }
    }
}
