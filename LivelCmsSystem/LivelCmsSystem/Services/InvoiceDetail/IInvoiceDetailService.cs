using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public interface IInvoiceDetailService 
    {
        void Create(InvoiceDetailViewModel model);
        InvoiceDetailViewModel Read(Guid id);
        void Update(InvoiceDetailViewModel model);
        void Delete(Guid id);
        List<InvoiceDetailViewModel> GetAll();

        List<InvoiceDetailViewModel> GetAllByInvoiceId(Guid id);
    }
}
