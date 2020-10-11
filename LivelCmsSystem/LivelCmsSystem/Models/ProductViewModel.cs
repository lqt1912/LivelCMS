using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Models
{
    public partial class ProductViewModel
    {
        public ProductViewModel()
        {
            InvoiceDetail = new HashSet<InvoiceDetailViewModel>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? Brand { get; set; }
        public int? UnitPrice { get; set; }
        public Guid? ProductType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual BrandViewModel BrandNavigation { get; set; }
        public virtual ProductTypeViewModel ProductTypeNavigation { get; set; }
        public virtual ICollection<InvoiceDetailViewModel> InvoiceDetail { get; set; }
    }
}
