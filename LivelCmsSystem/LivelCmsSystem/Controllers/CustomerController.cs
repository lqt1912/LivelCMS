using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivelCMSSystem.Core.Repository;
using LivelCMSSystem.Helpers;
using LivelCMSSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivelCmsSystem.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(CustomerViewModel model)
        {
            var a = customerService.GetAll().FirstOrDefault(x => x.Email == model.Email);
            var b = customerService.GetAll().FirstOrDefault(x => x.PhoneNumber == model.PhoneNumber);
            if (a == null && b == null)
            {
                if (ModelState.IsValid)
                {
                    model.Id = Guid.NewGuid();
                    model.IsActive = true;
                    model.CreatedDate = DateTime.Now;
                    model.ModifiedDate = DateTime.Now;
                    customerService.Create(model);
                    return RedirectToAction("Customer", "Livel").WithSuccess("Thành công", "Thêm khách hàng thành công");
                }
                else return View();
            }
            return View().WithDanger("Lỗi", "Trùng thông tin");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(Guid id)
        {
            var data = customerService.Read(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult UpdateCustomer(CustomerViewModel model)
        {
          
                if (ModelState.IsValid)
                {
                    model.ModifiedDate = DateTime.Now;
                    customerService.Update(model);
                }
            return RedirectToAction("Customer", "Livel");
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(IFormCollection fc)
        {
            var guid = new Guid();
            if (Guid.TryParse(fc["Id"], out guid))
            {
                var data = customerService.Read(guid);
                if (data != null&& data.IsActive.Value ==true)
                {
                    return RedirectToAction("UpdateCustomer", "Customer", new { Id = fc["Id"] });
                }
                else return View().WithDanger("Lỗi", "Không tìm thấy khách hàng");
            }
            else return View().WithDanger("Lỗi", "Vui lòng nhập đúng định dạng");
        }

        public IActionResult DeleteCustomer(Guid id)
        {
            var data = customerService.Read(id);
            if (data != null)
            {
                customerService.Delete(id);
            }
            return RedirectToAction("Customer", "Livel").WithSuccess("Thành công", "Xóa khách hàng thành công");
        }
    }
}
