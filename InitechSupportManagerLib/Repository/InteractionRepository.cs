using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InitechSupportManagement.Entity;

namespace InitechSupportManagement.Repository
{
    public class InteractionRepository : MemoryRepository<Interaction>
    {
        public InteractionRepository(IEnumerable<Interaction> data = null) : base(data) { }

        protected override void SetAutoIdentity(Interaction entity)
        {
            if (!entity.Id.HasValue)
            {
                int? maxId = this.Data.Max(i => i.Id);

                entity.Id = maxId.HasValue ? maxId.Value + 1 : 1;
            }
        }
    }
}
