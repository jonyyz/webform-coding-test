using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitechSupportManagement.Entity
{
    public class Email : Interaction
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        public Email(int customerId) : base(customerId)
        {
            this.InteractionType = InteractionType.Email;
        }
    }
}
