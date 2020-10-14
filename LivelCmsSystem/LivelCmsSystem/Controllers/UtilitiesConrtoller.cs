using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using LivelCMSSystem.Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LivelCmsSystem.Controllers
{
    public class UtilitiesController : Controller
    {
        private readonly IInvoiceStatusService invoiceStatusService;
        private readonly IProductTypeService productTypeService;
        private readonly IBrandService brandService;

        public UtilitiesController(IInvoiceStatusService invoiceStatusService, IProductTypeService productTypeService, IBrandService brandService)
        {
            this.invoiceStatusService = invoiceStatusService;
            this.productTypeService = productTypeService;
            this.brandService = brandService;
        }

        public IActionResult InvoiceStatus()
        {
            return View(invoiceStatusService.GetAll());
        }

        public IActionResult ProductType()
        {
            return View(productTypeService.GetAll());
        }

        public IActionResult Brand()
        {
            return View(brandService.GetAll());
        }
    }
}
