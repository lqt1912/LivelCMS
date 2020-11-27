using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivelCmsSystem.Services.CustomDataAccess
{
    public class DataAccess : IDataAccess
    {

        public void AddInvoiceTotalPrice(Guid id, int price)
        {
            using (var _context = new ApplicationDbContext())
            {

                _context.Invoice.FirstOrDefault(x => x.Id == id).TotalPrice += price;
                _context.Invoice.FirstOrDefault(x => x.Id == id).RemainDebt += price;

                _context.SaveChanges();
            }

        }

        public void SubInvoiceTotalPrice(Guid id, int price)
        {
            using (var _context = new ApplicationDbContext())
            {
                _context.Invoice.FirstOrDefault(x => x.Id == id).TotalPrice -= price;
                _context.Invoice.FirstOrDefault(x => x.Id == id).RemainDebt -= price;
                _context.SaveChanges();
            }
        }

        public void UpdateInvoice(Guid id, InvoiceViewModel model)
        {
            using (var _context = new ApplicationDbContext())
            {
                var currentInvoice = _context.Invoice.FirstOrDefault(x => x.Id == id);
                currentInvoice.Status = model.Status;
                currentInvoice.ModifedDate = DateTime.Now;
                currentInvoice.Discription = model.Discription;
                currentInvoice.CustomerId = model.CustomerId;
                currentInvoice.RemainDebt = model.RemainDebt;
                _context.SaveChanges();
            }
        }
    }
}
