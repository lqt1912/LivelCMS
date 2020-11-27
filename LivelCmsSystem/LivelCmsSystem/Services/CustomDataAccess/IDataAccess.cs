using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivelCmsSystem.Services.CustomDataAccess
{
    public interface IDataAccess
    {
        void AddInvoiceTotalPrice(Guid id, int price);
        void SubInvoiceTotalPrice(Guid id, int price);

        void UpdateInvoice(Guid id, InvoiceViewModel model);

    }
}
