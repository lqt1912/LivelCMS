using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Models
{
    public partial class InvoiceDetailViewModel
    {
        public Guid Id { get; set; }
        public Guid? Product { get; set; }
        public int? Amount { get; set; }
        public int? UnitPrice { get; set; }
        public int? TotalPrice { get; set; }
        public Guid? InvoiceId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public virtual InvoiceViewModel Invoice { get; set; }
        public virtual ProductViewModel ProductNavigation { get; set; }
    }
}
