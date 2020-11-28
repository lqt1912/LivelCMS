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
    public class ProductController : Controller
    {
        private readonly IBrandService brandService;
        private readonly IProductTypeService productTypeService;
        private readonly IProductService productService;

        public ProductController(IBrandService brandService, IProductTypeService productTypeService, IProductService productService)
        {
            this.brandService = brandService;
            this.productTypeService = productTypeService;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            ViewBag.Brand = brandService.GetAll();
            ViewBag.ProductType = productTypeService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductViewModel model)
        {
            ViewBag.Brand = brandService.GetAll();
            ViewBag.ProductType = productTypeService.GetAll();

            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;

                model.Name =model.Name + " - "+ model.Id.ToString().Substring(0, 4).ToUpper();

                model.IsActive = true;
                productService.Create(model);
                return RedirectToAction("Product", "Livel").WithSuccess("Thành công", "Thêm sản phẩm thành công");

            }
            return View();
           
        }

        [HttpGet]
        public IActionResult UpdateProduct(Guid id)
        {
            //ViewBag.Brand = brandService.GetAll();
            //ViewBag.ProductType = productTypeService.GetAll();
            var data = productService.Read(id);
         
            ViewBag.Brand = brandService.GetName(data.Brand.Value);
            ViewBag.ProductType = productTypeService.GetName(data.ProductType.Value);
            return View(data);
        }

        [HttpPost]
        public IActionResult UpdateProduct(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.IsActive = true;
                model.ModifiedDate = DateTime.Now;
                productService.Update(model);

            }
            return RedirectToAction("Product", "Livel");
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
                var data = productService.Read(guid);
                if (data != null && data.IsActive ==true)
                {
                    return RedirectToAction("UpdateProduct", "Product", new { Id = fc["Id"] });
                }
                else return View().WithDanger("Lỗi", "Không tìm thấy sản phẩm");
            }
            else return View().WithDanger("Lỗi", "Vui lòng nhập đúng định dạng");
        }

        public IActionResult Delete(Guid id)
        {
            var data = productService.Read(id);
            if (data != null)
            {
                productService.Delete(id);
                return RedirectToAction("Product", "Livel").WithSuccess("Thành công", "Bạn đã xóa sản phẩm! ");
            }
            return RedirectToAction("Product", "Livel").WithDanger("Lỗi", "Xóa sản phẩm thất bại");
        }
    }
}
