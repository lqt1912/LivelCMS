using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public interface IInvoiceStatusService
    {
        void Create(InvoiceStatusViewModel model);
        InvoiceStatusViewModel Read(Guid id);
        void Update(InvoiceStatusViewModel model);
        void Delete(Guid id);
    }
}
