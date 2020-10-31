using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public interface IBrandService 
    {
        void Create(BrandViewModel model);
        BrandViewModel Read(Guid id);
        void Update(BrandViewModel model);
        void Delete(Guid id);

        List<BrandViewModel> GetAll();
        string GetName(Guid id);
    }
}
