using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Core.Repository;
using LivelCMSSystem.Helpers;
using LivelCMSSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivelCmsSystem.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly ICustomerService customerService;
        private readonly IProductService productService;
        private readonly IInvoiceService invoiceService;
        private readonly IInvoiceStatusService invoiceStatusService;
        private readonly IInvoiceDetailService invoiceDetailService;
        public InvoiceController(ICustomerService customerService, IProductService productService, IInvoiceService invoiceService, IInvoiceStatusService invoiceStatusService, IInvoiceDetailService invoiceDetailService)
        {
            this.customerService = customerService;
            this.productService = productService;
            this.invoiceService = invoiceService;
            this.invoiceStatusService = invoiceStatusService;
            this.invoiceDetailService = invoiceDetailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddInvoice()
        {
            ViewBag.Customer = customerService.GetAll();
            ViewBag.Product = productService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult AddInvoice(InvoiceViewModel model)
        {
            if(ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                var a = model.Id;
                model.Status = invoiceStatusService.GetAll().SingleOrDefault(x => x.Name == "Chưa thanh toán").Id;
                model.CreatedDate = DateTime.Now;
                model.ModifedDate = DateTime.Now;
                model.TotalPrice = 0;
                invoiceService.Create(model);
                ModelState.Clear();
                return RedirectToAction("InvoiceDetail", new { id=a});
            }
            return View();
        }

 
        [HttpGet]
        public IActionResult UpdateInvoice(Guid id)
        {
            var data = invoiceService.Read(id);
            ViewBag.InvoiceStatus = invoiceStatusService.GetAll();
            ViewBag.Customer = customerService.GetAll();
            return View(data);
        }


        [HttpPost]
        public IActionResult UpdateInvoice(InvoiceViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.ModifedDate = DateTime.Now;
                invoiceService.Update(model);
            }
            return RedirectToAction("Invoice", "Livel");
        }


        public IActionResult InvoiceDetail(Guid id)
        {
            ViewBag.Customer = customerService.GetAll();
            var data = invoiceService.Read(id);
            ViewBag.TotalPrice = 0;
            foreach (var item in invoiceDetailService.GetAllByInvoiceId(id))
            {
                ViewBag.TotalPrice += item.TotalPrice;
            }
            ViewBag.InvoiceDetail = invoiceDetailService.GetAllByInvoiceId(id);
            ViewBag.InvoiceStatus = invoiceStatusService.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult AddInvoiceDetail(Guid id)
        {
            ViewBag.Product = productService.GetAll();
            ViewBag.InvoiceId = id;
            return View();
        }

        [HttpPost]
        public IActionResult AddInvoiceDetail(InvoiceDetailViewModel model)
        {
            if(ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();

                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                model.UnitPrice = productService.Read(model.Product.Value).UnitPrice;
                model.TotalPrice = model.UnitPrice * model.Amount;

                var currentInvoice = invoiceService.Read(model.InvoiceId.Value);

                currentInvoice.TotalPrice += model.UnitPrice;

                invoiceDetailService.Create(model);

                return RedirectToAction("InvoiceDetail", new { id = currentInvoice.Id });
            }
            return View();
        }

        public IActionResult DeleteInvoiceDetail(Guid id, Guid invoiceId)
        {
            invoiceDetailService.Delete(id);
            return RedirectToAction("InvoiceDetail", new { id = invoiceId });
        }

    }
}
