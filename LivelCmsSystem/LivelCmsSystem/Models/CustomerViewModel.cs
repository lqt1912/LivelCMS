using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Models
{
    public partial class CustomerViewModel
    {
        public CustomerViewModel()
        {
            Invoice = new HashSet<InvoiceViewModel>();
            Receipt = new HashSet<ReceiptViewModel>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<InvoiceViewModel> Invoice { get; set; }
        public virtual ICollection<ReceiptViewModel> Receipt { get; set; }
    }
}
