using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class InvoiceDetailRepository : BaseRepository<InvoiceDetail>, IInvoiceDetailRepository
    {
        public InvoiceDetailRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
