using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitechSupportManagement.Entity
{
    /// <summary>
    /// The type of interaction that the customer had with the call center
    /// </summary>
    public enum InteractionType
    {
        /// <summary>
        /// The interaction type is unspecified
        /// </summary>
        Empty,
        /// <summary>
        /// A call to the call center.  If RespondedTo = false it's a voice mail that needs
        /// responded to.
        /// </summary>
        Call,
        /// <summary>
        /// An email was sent to the call center email address
        /// </summary>
        Email
    }
}
