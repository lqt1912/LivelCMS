using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class AspNetRolesRepository : BaseRepository<AspNetRoles>, IAspNetRolesRepository
    {
        public AspNetRolesRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
