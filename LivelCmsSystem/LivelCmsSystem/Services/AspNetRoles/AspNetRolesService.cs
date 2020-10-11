using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class AspNetRolesService:IAspNetRolesService
    {
        private readonly IAspNetRolesRepository aspNetRolesRepository;
        private readonly IMapper mapper;

        public AspNetRolesService(IAspNetRolesRepository aspNetRolesRepository, IMapper mapper)
        {
            this.aspNetRolesRepository = aspNetRolesRepository;
            this.mapper = mapper;
        }
    }
}
