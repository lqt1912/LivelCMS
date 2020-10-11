using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Models
{
    public partial class ReceiptViewModel
    {
        public Guid Id { get; set; }
        public Guid? CustomerId { get; set; }
        public int? ReceivedAmount { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual CustomerViewModel Customer { get; set; }
    }
}
