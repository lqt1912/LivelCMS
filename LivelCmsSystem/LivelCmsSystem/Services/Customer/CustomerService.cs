﻿using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IMapper mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            this.customerRepository = customerRepository;
            this.mapper = mapper;
        }

        public void Create(CustomerViewModel model)
        {
            var entity = mapper.Map(model, new Customer());
            customerRepository.Add(entity);
            customerRepository.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = customerRepository.GetById(id);
            customerRepository.Delete(entity);
            customerRepository.SaveChanges();
        }

        public CustomerViewModel Read(Guid id)
        {
            var entity = customerRepository.GetById(id);
            return mapper.Map(entity, new CustomerViewModel());
        }

        public void Update(CustomerViewModel model)
        {
            var entity = mapper.Map(model, new Customer());
            customerRepository.Update(entity);
            customerRepository.SaveChanges();
        }
    }
}
