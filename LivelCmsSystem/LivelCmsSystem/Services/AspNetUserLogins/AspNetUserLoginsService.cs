using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class AspNetUserLoginsService : IAspNetUserLoginsService
    {
        private readonly IAspNetUserLoginsRepository aspNetUserLoginsRepository;
        private readonly IMapper mapper;

        public AspNetUserLoginsService(IAspNetUserLoginsRepository aspNetUserLoginsRepository, IMapper mapper)
        {
            this.aspNetUserLoginsRepository = aspNetUserLoginsRepository;
            this.mapper = mapper;
        }
    }
}
