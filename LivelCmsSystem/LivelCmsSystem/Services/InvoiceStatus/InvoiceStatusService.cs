using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class InvoiceStatusService : IInvoiceStatusService
    {
        private readonly IInvoiceStatusRepository invoiceStatusRepository;
        private readonly IMapper mapper;

        public InvoiceStatusService(IInvoiceStatusRepository invoiceStatusRepository, IMapper mapper)
        {
            this.invoiceStatusRepository = invoiceStatusRepository;
            this.mapper = mapper;
        }

        public void Create(InvoiceStatusViewModel model)
        {
            var entity = mapper.Map(model, new InvoiceStatus());
            invoiceStatusRepository.Add(entity);
            invoiceStatusRepository.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = invoiceStatusRepository.GetById(id);
            invoiceStatusRepository.Delete(entity);
            invoiceStatusRepository.SaveChanges();
        }

        public List<InvoiceStatusViewModel> GetAll()
        {
            var result = invoiceStatusRepository.GetAll();
            return mapper.Map(result, new List<InvoiceStatusViewModel>());
        }

        public InvoiceStatusViewModel Read(Guid id)
        {
            var entity = invoiceStatusRepository.GetById(id);
            return mapper.Map(entity, new InvoiceStatusViewModel());
        }

        public void Update(InvoiceStatusViewModel model)
        {
            var entity = mapper.Map(model, new InvoiceStatus());
            invoiceStatusRepository.Update(entity);
            invoiceStatusRepository.SaveChanges();
        }
    }
}
