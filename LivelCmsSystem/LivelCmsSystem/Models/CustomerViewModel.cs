using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<InvoiceViewModel> Invoice { get; set; }
        public virtual ICollection<ReceiptViewModel> Receipt { get; set; }
    }
}
