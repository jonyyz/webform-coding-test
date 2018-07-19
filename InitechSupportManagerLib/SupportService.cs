using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InitechSupportManagement.Repository;

namespace InitechSupportManagement
{
    public static class SupportService
    {
        static CustomerRepository _customerRepository = null;
        static InteractionRepository _interactionRepository = null;

        public static CustomerRepository Customers
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository();
                }

                return _customerRepository;
            }
        }

        public static InteractionRepository Interactions
        {
            get
            {
                if (_interactionRepository == null)
                {
                    _interactionRepository = new InteractionRepository();
                }

                return _interactionRepository;
            }
        }
    }
}
