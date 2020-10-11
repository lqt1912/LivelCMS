using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class AspNetRoleClaimsRepository : BaseRepository<AspNetRoleClaims>, IAspNetRolesClaimsRepository
    {
        public AspNetRoleClaimsRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
