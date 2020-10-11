using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class ProductTypeRepository : BaseRepository<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
