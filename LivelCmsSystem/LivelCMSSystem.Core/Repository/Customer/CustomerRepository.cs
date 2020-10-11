using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
