using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Core.Models
{
    public partial class InvoiceDetail
    {
        public Guid Id { get; set; }
        public Guid? Product { get; set; }
        public int? Amount { get; set; }
        public int? UnitPrice { get; set; }
        public int? TotalPrice { get; set; }
        public Guid? InvoiceId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Product ProductNavigation { get; set; }
    }
}
