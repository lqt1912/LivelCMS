using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository invoiceRepository;
        private readonly IMapper mapper;

        public InvoiceService(IInvoiceRepository invoiceRepository, IMapper mapper)
        {
            this.invoiceRepository = invoiceRepository;
            this.mapper = mapper;
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
            var entity = mapper.Map(model, new Invoice());
            invoiceRepository.Update(entity);
            invoiceRepository.SaveChanges();
        }
    }
}
