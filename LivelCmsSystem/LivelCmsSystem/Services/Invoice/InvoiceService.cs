using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivelCMSSystem.Core.Repository
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository invoiceRepository;
        private readonly IMapper mapper;
        private readonly IInvoiceDetailService invoiceDetailService;

        public InvoiceService(IInvoiceRepository invoiceRepository, IMapper mapper, IInvoiceDetailService invoiceDetailService)
        {
            this.invoiceRepository = invoiceRepository;
            this.mapper = mapper;
            this.invoiceDetailService = invoiceDetailService;
        }
        public void Create(InvoiceViewModel model)
        {
            var entity = mapper.Map(model, new Invoice());
            invoiceRepository.Add(entity);
            invoiceRepository.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = invoiceRepository.GetById(id);
            invoiceRepository.Delete(entity);
            invoiceRepository.SaveChanges();
        }

        public List<InvoiceViewModel> GetAll()
        {
            var result = invoiceRepository.GetAll();
            return mapper.Map(result, new List<InvoiceViewModel>());
        }

        public InvoiceViewModel Read(Guid id)
        {
            var entity = invoiceRepository.GetById(id);
            return mapper.Map(entity, new InvoiceViewModel());
        }

        public void Update(InvoiceViewModel model)
        {
            var currentInvoice = invoiceRepository.GetById(model.Id);

            var entity = mapper.Map(model, new Invoice());

            currentInvoice = entity;

            invoiceRepository.Update(currentInvoice);

            invoiceRepository.SaveChanges();
        }

        public int TotalIncome(Guid id)
        {
            int result = 0;
            var invoiceDetails = invoiceDetailService.GetAllByInvoiceId(id);
            foreach (var item in invoiceDetails)
            {
                if(item.TotalPrice.HasValue)
                {
                    result = result + item.TotalPrice.Value;
                }
            }
            return result;
        }

        public async Task CreateAsync(InvoiceViewModel model)
        {
            var entity = mapper.Map(model, new Invoice());
            invoiceRepository.Add(entity);
            await invoiceRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(InvoiceViewModel model)
        {
            var entity = mapper.Map(model, new Invoice());

            invoiceRepository.Update(entity);

            await invoiceRepository.SaveChangesAsync();
        }

        public async Task<InvoiceViewModel> ReadAsync(Guid id)
        {
            var entity =await  invoiceRepository.GetAsyncById(id);
            return mapper.Map(entity, new InvoiceViewModel());
        }
    }
}
