using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class BrandRepository : BaseRepository<Brand>, IBrandRepository
    {
        public BrandRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
