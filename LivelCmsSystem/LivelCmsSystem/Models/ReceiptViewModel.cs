using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LivelCMSSystem.Models
{
    public partial class ReceiptViewModel
    {
        public Guid Id { get; set; }

        public Guid? CustomerId { get; set; }

        [Required]
        public int? ReceivedAmount { get; set; }

        [Required]
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        [Required]
        public Guid? InvoiceId { get; set; }

        public virtual CustomerViewModel Customer { get; set; }
    }
}
