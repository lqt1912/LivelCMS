using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class AspNetUserTokensRepository : BaseRepository<AspNetUserTokens>, IAspNetUserTokensRepository
    {
        public AspNetUserTokensRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
