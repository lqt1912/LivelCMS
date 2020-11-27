using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivelCMSSystem.Core.Repository
{
    public interface IInvoiceService
    {
        void Create(InvoiceViewModel model);

        Task CreateAsync(InvoiceViewModel model);
        InvoiceViewModel Read(Guid id);

        Task<InvoiceViewModel> ReadAsync(Guid id);
        void Update(InvoiceViewModel model);

        Task UpdateAsync(InvoiceViewModel model);
        void Delete(Guid id);
        List<InvoiceViewModel> GetAll();

        int TotalIncome(Guid id);
    }
}
