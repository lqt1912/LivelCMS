using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public interface IInvoiceService
    {
        void Create(InvoiceViewModel model);
        InvoiceViewModel Read(Guid id);
        void Update(InvoiceViewModel model);
        void Delete(Guid id);
    }
}
