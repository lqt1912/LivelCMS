using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class AspNetUsersRepository : BaseRepository<AspNetUsers>, IAspNetUsersRepository
    {
        public AspNetUsersRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
