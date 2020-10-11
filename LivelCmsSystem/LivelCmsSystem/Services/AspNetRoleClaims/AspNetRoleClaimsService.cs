using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class AspNetRoleClaimsService : IAspNetRoleClaimsService
    {
        private readonly IAspNetRolesClaimsRepository aspNetRolesClaimsRepository;
        private readonly IMapper mapper;

        public AspNetRoleClaimsService(IAspNetRolesClaimsRepository aspNetRolesClaimsRepository, IMapper mapper)
        {
            this.aspNetRolesClaimsRepository = aspNetRolesClaimsRepository;
            this.mapper = mapper;
        }
    }
}
