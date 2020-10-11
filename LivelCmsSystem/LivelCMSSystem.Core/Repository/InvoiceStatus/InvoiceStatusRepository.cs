using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class InvoiceStatusRepository : BaseRepository<InvoiceStatus>, IInvoiceStatusRepository
    {
        public InvoiceStatusRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
