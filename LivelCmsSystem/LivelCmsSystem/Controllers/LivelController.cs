using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using LivelCMSSystem.Core.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LivelCmsSystem.Controllers
{
   // [Authorize]
    public class LivelController : Controller
    {
        private readonly IProductService productService;
        private readonly ICustomerService customerService;
        private readonly IInvoiceService invoiceService;
        private readonly IInvoiceDetailService invoiceDetailService;
        private readonly IReceiptService receiptService;
        public LivelController(IProductService productService, ICustomerService customerService, IInvoiceService invoiceService, IReceiptService receiptService, IInvoiceDetailService invoiceDetailService)
        {
            this.productService = productService;
            this.customerService = customerService;
            this.invoiceService = invoiceService;
            this.receiptService = receiptService;
            this.invoiceDetailService = invoiceDetailService;
        }

        public IActionResult Index()
        {
            ViewBag.ProductNumber = productService.GetAll().Count;
            ViewBag.CustomerNumber = customerService.GetAll().Count;
            ViewBag.InvoiceNumber = invoiceService.GetAll().Count;
            ViewBag.ReceiptNumber = receiptService.GetAll().Count;
            var totalIncome = 0;
            foreach (var item in invoiceService.GetAll())
            {
                if(item.Status.Value == Guid.Parse("d2eb43bf-f6f0-4fa1-af9b-97fce37977c6"))
                {
                totalIncome = totalIncome + invoiceService.TotalIncome(item.Id);
                }
            }
            ViewBag.TotalIncome = totalIncome;
            return View();
        }

        [Route("danh-sach-san-pham")]
        public IActionResult Product()
        {
            return View(productService.GetAll());
        }

        [Route("danh-sach-hoa-don")]
        public IActionResult Invoice()
        {
            return View(invoiceService.GetAll());
        }

        [Route("danh-sach-khach-hang")]
        public IActionResult Customer()
        {
            return View(customerService.GetAll());
        }

        [Route("danh-sach-chung-tu")]
        public IActionResult Receipt()
        {

            return View(receiptService.GetAll());
        }

        [Route("lien-he")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
