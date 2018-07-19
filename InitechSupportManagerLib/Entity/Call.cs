using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitechSupportManagement.Entity
{
    public class Call : Interaction
    {
        public string PhoneNumber { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Call" /> class.
        /// </summary>
        /// <param name="customerId">The customer identifier</param>
        public Call(int customerId) : base(customerId)
        {
            this.InteractionType = InteractionType.Call;
        }
    }
}
