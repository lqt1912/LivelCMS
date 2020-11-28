using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using LivelCmsSystem.Services.CustomDataAccess;
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
        private readonly IDataAccess dataAccess;
        public InvoiceController(ICustomerService customerService, IProductService productService, IInvoiceService invoiceService, IInvoiceStatusService invoiceStatusService, IInvoiceDetailService invoiceDetailService, IDataAccess dataAccess)
        {
            this.customerService = customerService;
            this.productService = productService;
            this.invoiceService = invoiceService;
            this.invoiceStatusService = invoiceStatusService;
            this.invoiceDetailService = invoiceDetailService;
            this.dataAccess = dataAccess;
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
                model.RemainDebt = 0;
                invoiceService.Create(model);
                ModelState.Clear();
                return RedirectToAction("InvoiceDetail", new { id=a});
            }
            ViewBag.Customer = customerService.GetAll();
            ViewBag.Product = productService.GetAll();
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
                dataAccess.UpdateInvoice(model.Id, model);
            }
            return RedirectToAction("InvoiceDetail", new { id=model.Id}).WithSuccess("Thành công", "Chỉnh sửa thành công");
        }


        public IActionResult InvoiceDetail(Guid id)
        {
            ViewBag.Customer = customerService.GetAll();
            var data = invoiceService.Read(id);

            if (data.TotalPrice.HasValue)
                ViewBag.TotalPrice = data.TotalPrice.Value.ToString("N0");
            else ViewBag.TotalPrice = 0;


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
        public async Task<IActionResult> AddInvoiceDetail(InvoiceDetailViewModel model)
        {
            if(ModelState.IsValid)
            {
                if(!(await productService.ReadAsync(model.Product.Value)!=null) || model.Amount.Value<1 || model.Amount.Value>50)
                {
                    return RedirectToAction("InvoiceDetail", new { id = model.InvoiceId.Value }).WithDanger("Lỗi","Thêm chi tiết thất bại");
                }
                model.Id = Guid.NewGuid();

                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;

                model.UnitPrice = (await productService.ReadAsync(model.Product.Value)).UnitPrice;
                model.TotalPrice = model.UnitPrice * model.Amount;

                var currentInvoice = await invoiceService.ReadAsync(model.InvoiceId.Value);

                currentInvoice.TotalPrice += model.UnitPrice;
                await invoiceDetailService.CreateAsync(model);

            

                return RedirectToAction("InvoiceDetail", new { id = currentInvoice.Id }).WithSuccess("Thành công","Thêm chi tiết hóa đơn thành công");
            }

            ViewBag.Product = productService.GetAll();
            ViewBag.InvoiceId = model.InvoiceId.Value;
            return RedirectToAction("AddInvoiceDetail", new { id=model.InvoiceId.Value}).WithDanger("Lỗi", "Thêm chi tiết hóa đơn thất bại");
        }

        public IActionResult DeleteInvoiceDetail(Guid id, Guid invoiceId)
        {
            invoiceDetailService.Delete(id);
            return RedirectToAction("InvoiceDetail", new { id = invoiceId });
        }

    }
}
