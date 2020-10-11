using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Core.Models
{
    public partial class ProductType
    {
        public ProductType()
        {
            Product = new HashSet<Product>();
        }

        public Guid Id { get; set; }
        public string ProductTypeName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
