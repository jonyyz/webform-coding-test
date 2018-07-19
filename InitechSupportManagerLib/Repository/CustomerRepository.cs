using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InitechSupportManagement.Entity;

namespace InitechSupportManagement.Repository
{
    public class CustomerRepository : MemoryRepository<Customer>
    {
        public CustomerRepository(IEnumerable<Customer> data = null) : base(data) {}

        protected override void SetAutoIdentity(Customer entity)
        {
            if (!entity.Id.HasValue)
            {
                int? maxId = this.Data.Max(c => c.Id);

                entity.Id = maxId.HasValue ? maxId.Value + 1 : 1;
            }
        }
    }
}
