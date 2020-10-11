using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class AspNetUserRolesRepository : BaseRepository<AspNetUserRoles>, IAspNetUserRolesRepository
    {
        public AspNetUserRolesRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
