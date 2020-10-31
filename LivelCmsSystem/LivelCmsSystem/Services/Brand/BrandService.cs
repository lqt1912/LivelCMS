using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository brandRepository;
        private readonly IMapper mapper;

        public BrandService(IBrandRepository brandRepository, IMapper mapper)
        {
            this.brandRepository = brandRepository;
            this.mapper = mapper;
        }

        public void Create(BrandViewModel model)
        {
            var entity = mapper.Map(model, new Brand());
            brandRepository.Add(entity);
            brandRepository.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = brandRepository.GetById(id);
            brandRepository.Delete(entity);
            brandRepository.SaveChanges();
        }

        public List<BrandViewModel> GetAll()
        {
            var result = brandRepository.GetAll();
            return mapper.Map(result, new List<BrandViewModel>());
        }

        public string GetName(Guid id)
        {
            return brandRepository.GetById(id).BrandName;
        }

        public BrandViewModel Read(Guid id)
        {
            var entity = brandRepository.GetById(id);
            return mapper.Map(entity, new BrandViewModel());
        }

        public void Update(BrandViewModel model)
        {
            var entity = mapper.Map(model, new Brand());
            brandRepository.Update(entity);
            brandRepository.SaveChanges();
        }
    }
}
