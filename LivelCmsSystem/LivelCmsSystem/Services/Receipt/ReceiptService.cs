using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class ReceiptService : IReceiptService
    {
        private readonly IReceiptRepository receiptRepository;
        private readonly IMapper mapper;

        public ReceiptService(IReceiptRepository receiptRepository, IMapper mapper)
        {
            this.receiptRepository = receiptRepository;
            this.mapper = mapper;
        }

        public void Create(ReceiptViewModel model)
        {

            receiptRepository.Add(mapper.Map(model, new Receipt()));
            receiptRepository.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = receiptRepository.GetById(id);
            receiptRepository.Delete(entity);
            receiptRepository.SaveChanges();
        }

        public List<ReceiptViewModel> GetAll()
        {
            var result = receiptRepository.GetAll();
            return mapper.Map(result, new List<ReceiptViewModel>());
        }

        public ReceiptViewModel Read(Guid id)
        {
            var entity = receiptRepository.GetById(id);
            return mapper.Map(entity, new ReceiptViewModel());
        }

        public void Update(ReceiptViewModel model)
        {
            var entity = mapper.Map(model, new Receipt());
            receiptRepository.Update(entity);
            receiptRepository.SaveChanges();
        }


    }
}
