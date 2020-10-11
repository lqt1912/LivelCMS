using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public interface ICustomerService 
    {
        void Create(CustomerViewModel model);
        CustomerViewModel Read(Guid id);
        void Update(CustomerViewModel model);
        void Delete(Guid id);
    }
}
