using AutoMapper;
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
            entity.IsActive = false;
            productRepository.Update(entity);
            productRepository.SaveChanges();
        }

        public List<ProductViewModel> GetAll()
        {
            var result = productRepository.GetAll().Where(x=>x.IsActive==true);
            return mapper.Map(result, new List<ProductViewModel>());
        }

        public ProductViewModel Read(Guid id)
        {
            var entity = productRepository.GetById(id);
            return mapper.Map(entity, new ProductViewModel());
        }

        public async Task<ProductViewModel> ReadAsync(Guid id)
        {
            var entity = await productRepository.GetAsyncById(id);
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
