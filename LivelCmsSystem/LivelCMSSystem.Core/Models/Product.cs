using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Core.Models
{
    public partial class Product
    {
        public Product()
        {
            InvoiceDetail = new HashSet<InvoiceDetail>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? Brand { get; set; }
        public int? UnitPrice { get; set; }
        public Guid? ProductType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Brand BrandNavigation { get; set; }
        public virtual ProductType ProductTypeNavigation { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetail { get; set; }
    }
}
