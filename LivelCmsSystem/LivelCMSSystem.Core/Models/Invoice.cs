using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Core.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceDetail = new HashSet<InvoiceDetail>();
        }

        public Guid Id { get; set; }
        public string Discription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifedDate { get; set; }
        public int? TotalPrice { get; set; }
        public Guid? Status { get; set; }
        public Guid? CustomerId { get; set; }

        public int? RemainDebt { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual InvoiceStatus StatusNavigation { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetail { get; set; }
    }
}
