using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Models
{
    public partial class ProductTypeViewModel
    {
        public ProductTypeViewModel()
        {
            Product = new HashSet<ProductViewModel>();
        }

        public Guid Id { get; set; }
        public string ProductTypeName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<ProductViewModel> Product { get; set; }
    }
}
