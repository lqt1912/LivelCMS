using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public void Create(ProductViewModel model)
        {
            var entity = mapper.Map(model, new Product());
            productRepository.Add(entity);
            productRepository.SaveChanges();

        }

        public void Delete(Guid id)
        {
            var entity = productRepository.GetById(id);
            productRepository.Delete(entity);
            productRepository.SaveChanges();
        }

        public List<ProductViewModel> GetAll()
        {
            var result = productRepository.GetAll();
            return mapper.Map(result, new List<ProductViewModel>());
        }

        public ProductViewModel Read(Guid id)
        {
            var entity = productRepository.GetById(id);
            return mapper.Map(entity, new ProductViewModel());
        }

        public void Update(ProductViewModel model)
        {
            var entity = mapper.Map(model, new Product());
            productRepository.Update(entity);
            productRepository.SaveChanges();
        }
    }
}
