using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LivelCMSSystem.Models
{
    public partial class ProductViewModel
    {
        public ProductViewModel()
        {
            InvoiceDetail = new HashSet<InvoiceDetailViewModel>();
        }

        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        public Guid? Brand { get; set; }

        [Required]
        public int? UnitPrice { get; set; }
        public Guid? ProductType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        public virtual BrandViewModel BrandNavigation { get; set; }
        public virtual ProductTypeViewModel ProductTypeNavigation { get; set; }
        public virtual ICollection<InvoiceDetailViewModel> InvoiceDetail { get; set; }
    }
}
