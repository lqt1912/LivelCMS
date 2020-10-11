using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class AspNetUserClaimsService : IAspNetUserClaimsService
    {
        private readonly IAspNetUserClaimsRepository aspNetUserClaimsRepository;
        private readonly IMapper mapper;

        public AspNetUserClaimsService(IAspNetUserClaimsRepository aspNetUserClaimsRepository, IMapper mapper)
        {
            this.aspNetUserClaimsRepository = aspNetUserClaimsRepository;
            this.mapper = mapper;
        }
    }
}
