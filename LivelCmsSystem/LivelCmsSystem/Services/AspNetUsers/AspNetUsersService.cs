﻿using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class AspNetUsersService : IAspNetUsersService
    {
        private readonly IAspNetUsersRepository aspNetUsersRepository;
        private readonly IMapper mapper;

        public AspNetUsersService(IAspNetUsersRepository aspNetUsersRepository, IMapper mapper)
        {
            this.aspNetUsersRepository = aspNetUsersRepository;
            this.mapper = mapper;
        }
    }
}
