﻿using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class AspNetUserLoginsRepository : BaseRepository<AspNetUserLogins>, IAspNetUserLoginsRepository
    {
        public AspNetUserLoginsRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
