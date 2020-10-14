using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivelCMSSystem.Core.Repository;
using LivelCMSSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LivelCmsSystem.Controllers
{
    public class ReceiptController : Controller
    {

        private readonly ICustomerService customerService;
        private readonly IReceiptService receiptService;

        public ReceiptController(ICustomerService customerService, IReceiptService receiptService)
        {
            this.customerService = customerService;
            this.receiptService = receiptService;
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
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                receiptService.Create(model);
                return RedirectToAction("ReceiptDetail", new { id = model.Id });
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
