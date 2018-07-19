using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitechSupportManagement.Entity
{
    public class Customer
    {
        public int? Id { get; set; }
        public string CompanyName { get; set; }
        public Address Address { get; set; }
        public DateTime SoftwarePurchaseDate { get; set; }

        public override string ToString()
        {
            return this.CompanyName;
        }
    }
}
