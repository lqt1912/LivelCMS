using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivelCmsSystem.Services.CustomDataAccess;
using LivelCMSSystem.Core.Repository;
using LivelCMSSystem.Helpers;
using LivelCMSSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LivelCmsSystem.Controllers
{
    public class ReceiptController : Controller
    {

        private readonly ICustomerService customerService;
        private readonly IReceiptService receiptService;
        private readonly IInvoiceService invoiceService;
        private readonly IDataAccess dataAccess;
        public ReceiptController(ICustomerService customerService, IReceiptService receiptService, IInvoiceService invoiceService, IDataAccess dataAccess)
        {
            this.customerService = customerService;
            this.receiptService = receiptService;
            this.invoiceService = invoiceService;
            this.dataAccess = dataAccess;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReceiptDetail(Guid id)
        {
            var data = receiptService.Read(id);
            return View(data);
        }

       [HttpGet]
        public IActionResult AddReceipt()
        {
            ViewBag.Customer = customerService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult AddReceipt(ReceiptViewModel model)
        {
            ViewBag.Customer = customerService.GetAll();
            if (ModelState.IsValid)
            {
                var a = invoiceService.Read(model.InvoiceId.Value);
                if (a == null || model.ReceivedAmount == null)
                {
                    return RedirectToAction("AddReceipt").WithDanger("Lỗi", "Tạo chứng từ thất bại");
                } else if (model.ReceivedAmount.Value > invoiceService.Read(model.InvoiceId.Value).RemainDebt.Value || model.ReceivedAmount.Value <1)
                {
                    return RedirectToAction("AddReceipt").WithDanger("Lỗi", "Tạo chứng từ thất bại, giá trị không phù hợp");
                }
                else if(model.CustomerId.Value != invoiceService.Read(model.InvoiceId.Value).CustomerId)
                {
                    return RedirectToAction("AddReceipt").WithDanger("Lỗi", "Tạo chứng từ thất bại, không đúng tên khách hàng");
                }


                var invoice = invoiceService.Read(model.InvoiceId.Value);
                invoice.RemainDebt = invoice.RemainDebt - model.ReceivedAmount;

                if (invoice.RemainDebt.Value <= 0)
                    invoice.Status = Guid.Parse("d2eb43bf-f6f0-4fa1-af9b-97fce37977c6");
                else if (invoice.RemainDebt > 0)
                    invoice.Status = Guid.Parse("3f74b911-771a-4af4-b297-79b7c3c695a5");

                dataAccess.UpdateInvoice(model.InvoiceId.Value, invoice);

                model.Id = Guid.NewGuid();
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                receiptService.Create(model);
                return RedirectToAction("Receipt","Livel");
            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateReceipt(Guid id)
        {
            ViewBag.Customer = customerService.GetAll();
            var data = receiptService.Read(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult UpdateReceipt(ReceiptViewModel model)
        {
            ViewBag.Customer = customerService.GetAll();
            if (ModelState.IsValid)
            {
                model.ModifiedDate = DateTime.Now;
                receiptService.Create(model);
                return RedirectToAction("ReceiptDetail", new { id = model.Id });
            }
            return View();
        }

    }
}
