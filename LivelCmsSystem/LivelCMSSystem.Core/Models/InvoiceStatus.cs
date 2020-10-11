using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Core.Models
{
    public partial class InvoiceStatus
    {
        public InvoiceStatus()
        {
            Invoice = new HashSet<Invoice>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
