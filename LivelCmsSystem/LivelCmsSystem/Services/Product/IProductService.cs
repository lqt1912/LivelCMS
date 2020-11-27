using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivelCMSSystem.Core.Repository
{
    public interface IProductService
    {
        void Create(ProductViewModel model);
        ProductViewModel Read(Guid id);
        Task<ProductViewModel> ReadAsync(Guid id);

        void Update(ProductViewModel model);
        void Delete(Guid id);

        List<ProductViewModel> GetAll();
    }
}
