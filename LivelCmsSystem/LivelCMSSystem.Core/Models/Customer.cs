using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Core.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Invoice = new HashSet<Invoice>();
            Receipt = new HashSet<Receipt>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<Receipt> Receipt { get; set; }
    }
}
