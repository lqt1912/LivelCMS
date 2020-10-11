using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class InvoiceDetailService : IInvoiceDetailService
    {

        private readonly IInvoiceDetailRepository invoiceDetailRepository;
        private readonly IMapper mapper;

        public InvoiceDetailService(IInvoiceDetailRepository invoiceDetailRepository, IMapper mapper)
        {
            this.invoiceDetailRepository = invoiceDetailRepository;
            this.mapper = mapper;
        }
        public void Create(InvoiceDetailViewModel model)
        {
            var entity = mapper.Map(model, new InvoiceDetail());
            invoiceDetailRepository.Add(entity);
            invoiceDetailRepository.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = invoiceDetailRepository.GetById(id);
            invoiceDetailRepository.Delete(entity);
            invoiceDetailRepository.SaveChanges();
        }

        public InvoiceDetailViewModel Read(Guid id)
        {
            var entity = invoiceDetailRepository.GetById(id);
            return mapper.Map(entity, new InvoiceDetailViewModel());
        }

        public void Update(InvoiceDetailViewModel model)
        {
            var entity = mapper.Map(model, new InvoiceDetail());
            invoiceDetailRepository.Update(entity);
            invoiceDetailRepository.SaveChanges();
        }
    }
}
