using AutoMapper;
using LivelCmsSystem.Services.CustomDataAccess;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivelCMSSystem.Core.Repository
{
    public class InvoiceDetailService : IInvoiceDetailService
    {

        private readonly IInvoiceDetailRepository invoiceDetailRepository;
        private readonly IInvoiceRepository invoiceRepository;
        private readonly IMapper mapper;
        private readonly IDataAccess dataAccess;

        public InvoiceDetailService(IInvoiceDetailRepository invoiceDetailRepository, IMapper mapper, IInvoiceRepository invoiceRepository, IDataAccess dataAccess)
        {
            this.invoiceDetailRepository = invoiceDetailRepository;
            this.mapper = mapper;
            this.invoiceRepository = invoiceRepository;
            this.dataAccess = dataAccess;
        }
        public void Create(InvoiceDetailViewModel model)
        {
            var entity = mapper.Map(model, new InvoiceDetail());
            invoiceDetailRepository.Add(entity);
            invoiceDetailRepository.SaveChanges();
        }

        public async Task CreateAsync(InvoiceDetailViewModel model)
        {
            var entity = mapper.Map(model, new InvoiceDetail());
            invoiceDetailRepository.Add(entity);
            await invoiceDetailRepository.SaveChangesAsync();

            dataAccess.AddInvoiceTotalPrice(entity.InvoiceId.Value, entity.TotalPrice.Value);
        }

        public void Delete(Guid id)
        {
            var entity = invoiceDetailRepository.GetById(id);
            dataAccess.SubInvoiceTotalPrice(entity.InvoiceId.Value, entity.TotalPrice.Value);
            invoiceDetailRepository.Delete(entity);
            invoiceDetailRepository.SaveChanges();
        }

        public List<InvoiceDetailViewModel> GetAll()
        {
            var result = invoiceDetailRepository.GetAll();
            return mapper.Map(result, new List<InvoiceDetailViewModel>());
        }

        public List<InvoiceDetailViewModel> GetAllByInvoiceId(Guid id)
        {
            var result = invoiceDetailRepository.GetAll().Where(x => x.InvoiceId == id);
            return mapper.Map(result, new List<InvoiceDetailViewModel>());
        }

        public InvoiceDetailViewModel Read(Guid id)
        {
            var entity = invoiceDetailRepository.GetById(id);
            return mapper.Map(entity, new InvoiceDetailViewModel());
        }

        public int TotalIncome()
        {
            int totalIncome = 0;
            return totalIncome;
        }

        public void Update(InvoiceDetailViewModel model)
        {
            var entity = mapper.Map(model, new InvoiceDetail());
            invoiceDetailRepository.Update(entity);
            invoiceDetailRepository.SaveChanges();
        }

        public async Task UpdateAsync(InvoiceDetailViewModel model)
        {
            var entity = mapper.Map(model, new InvoiceDetail());
            invoiceDetailRepository.Update(entity);
            await invoiceDetailRepository.SaveChangesAsync();
        }
    }
}
