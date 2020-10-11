using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly IProductTypeRepository productTypeRepository;
        private readonly IMapper mapper;

        public ProductTypeService(IProductTypeRepository productTypeRepository, IMapper mapper)
        {
            this.productTypeRepository = productTypeRepository;
            this.mapper = mapper;
        }

        public void Create(ProductTypeViewModel model)
        {
            var entity = mapper.Map(model, new ProductType());
            productTypeRepository.Add(entity);
            productTypeRepository.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = productTypeRepository.GetById(id);
            productTypeRepository.Delete(entity);
            productTypeRepository.SaveChanges();
        }

        public ProductTypeViewModel Read(Guid id)
        {
            var entity = productTypeRepository.GetById(id);
            return mapper.Map(entity, new ProductTypeViewModel());
        }

        public void Update(ProductTypeViewModel model)
        {
            var entity = mapper.Map(model, new ProductType());
            productTypeRepository.Update(entity);
            productTypeRepository.SaveChanges();
        }
    }
}
