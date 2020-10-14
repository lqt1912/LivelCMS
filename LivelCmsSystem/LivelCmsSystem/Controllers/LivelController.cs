using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using LivelCMSSystem.Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LivelCmsSystem.Controllers
{
    public class LivelController : Controller
    {
        private readonly IProductService productService;
        private readonly ICustomerService customerService;
        private readonly IInvoiceService invoiceService;
        private readonly IReceiptService receiptService;
        public LivelController(IProductService productService, ICustomerService customerService, IInvoiceService invoiceService, IReceiptService receiptService)
        {
            this.productService = productService;
            this.customerService = customerService;
            this.invoiceService = invoiceService;
            this.receiptService = receiptService;
        }

        public IActionResult Index()
        {
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

        public IActionResult Receipt()
        {

            return View(receiptService.GetAll());
        }
    }
}
