using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public interface IProductTypeService 
    {
        void Create(ProductTypeViewModel model);
        ProductTypeViewModel Read(Guid id);
        void Update(ProductTypeViewModel model);
        void Delete(Guid id);
        List<ProductTypeViewModel> GetAll();
    }
}
