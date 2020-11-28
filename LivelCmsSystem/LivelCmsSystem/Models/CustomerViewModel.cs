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
        [StringLength(100, MinimumLength = 10)]
        [MaxLength]
        public string Name { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 10)]
        [MaxLength]
        public string Address { get; set; }

        [Required]
        [StringLength(12, MinimumLength =10)]
        [MaxLength]
        [RegularExpression("([0-9]+)", ErrorMessage="Sai định dạng số điện thoại")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 20)]
        [MaxLength]
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<InvoiceViewModel> Invoice { get; set; }
        public virtual ICollection<ReceiptViewModel> Receipt { get; set; }
    }
}
