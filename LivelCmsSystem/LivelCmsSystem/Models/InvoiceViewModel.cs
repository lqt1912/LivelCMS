using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LivelCMSSystem.Models
{
    public partial class InvoiceViewModel
    {
        public InvoiceViewModel()
        {
            InvoiceDetail = new HashSet<InvoiceDetailViewModel>();
        }

        public Guid Id { get; set; }

        public string Discription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifedDate { get; set; }
        public int? TotalPrice { get; set; }

        public int? RemainDebt { get; set; }
        public Guid? Status { get; set; }
        public Guid? CustomerId { get; set; }

        public virtual CustomerViewModel Customer { get; set; }
        public virtual InvoiceStatusViewModel StatusNavigation { get; set; }
        public virtual ICollection<InvoiceDetailViewModel> InvoiceDetail { get; set; }
    }
}
