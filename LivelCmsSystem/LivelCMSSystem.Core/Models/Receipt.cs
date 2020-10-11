using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Core.Models
{
    public partial class Receipt
    {
        public Guid Id { get; set; }
        public Guid? CustomerId { get; set; }
        public int? ReceivedAmount { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
