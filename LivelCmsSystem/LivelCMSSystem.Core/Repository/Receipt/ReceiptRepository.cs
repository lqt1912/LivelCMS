﻿using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public class ReceiptRepository : BaseRepository<Receipt>, IReceiptRepository
    {
        public ReceiptRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
