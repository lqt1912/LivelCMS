using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class AspNetUserRolesService : IAspNetUserRolesService
    {
        private readonly IAspNetUserRolesRepository aspNetUserRolesRepository;
        private readonly IMapper mapper;

        public AspNetUserRolesService(IAspNetUserRolesRepository aspNetUserRolesRepository, IMapper mapper)
        {
            this.aspNetUserRolesRepository = aspNetUserRolesRepository;
            this.mapper = mapper;
        }
    }
}
