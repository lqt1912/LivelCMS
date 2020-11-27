using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivelCMSSystem.Core.Repository
{
    public interface IInvoiceDetailService 
    {
        void Create(InvoiceDetailViewModel model);
        Task CreateAsync(InvoiceDetailViewModel model);

        InvoiceDetailViewModel Read(Guid id);
        void Update(InvoiceDetailViewModel model);
        Task UpdateAsync(InvoiceDetailViewModel model);
        void Delete(Guid id);
        List<InvoiceDetailViewModel> GetAll();

        List<InvoiceDetailViewModel> GetAllByInvoiceId(Guid id);

        int TotalIncome();
    }
}
