using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Models
{
    public partial class InvoiceStatusViewModel
    {
        public InvoiceStatusViewModel()
        {
            Invoice = new HashSet<InvoiceViewModel>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<InvoiceViewModel> Invoice { get; set; }
    }
}
