using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class AspNetUserClaimsRepository : BaseRepository<AspNetUserClaims>, IAspNetUserClaimsRepository
    {
        public AspNetUserClaimsRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
