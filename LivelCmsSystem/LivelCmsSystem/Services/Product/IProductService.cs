using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public interface IProductService
    {
        void Create(ProductViewModel model);
        ProductViewModel Read(Guid id);
        void Update(ProductViewModel model);
        void Delete(Guid id);

        List<ProductViewModel> GetAll();
    }
}
