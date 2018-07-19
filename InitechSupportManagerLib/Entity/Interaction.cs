using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitechSupportManagement.Entity
{
    public abstract class Interaction
    {
        public int? Id { get; set; }
        public int CustomerId { get; set; }
        public InteractionType InteractionType { get; set; }
        public DateTime ReceiveDateTime { get; set; }
        public string ContactName { get; set; }
        public bool RespondedTo { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Interaction"/> class.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        public Interaction(int customerId)
        {
            // Initialize Default Values
            this.InteractionType = InteractionType.Empty;
            this.RespondedTo = false;

            this.CustomerId = customerId;
        }
    }
}
