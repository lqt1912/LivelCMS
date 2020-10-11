using AutoMapper;
using LivelCMSSystem.Core.BaseRepository;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCMSSystem.Core.Repository
{
    public interface IReceiptService 
    {
        void Create(ReceiptViewModel model);
        ReceiptViewModel Read(Guid id);
        void Update(ReceiptViewModel model);
        void Delete(Guid id);
    }
}
