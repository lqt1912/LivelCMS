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
            if(ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                model.IsActive = true;
                productService.Create(model);

            }
            return RedirectToAction("Product", "Livel");
        }

        [HttpGet]
        public IActionResult UpdateProduct(Guid id )
        {
            ViewBag.Brand = brandService.GetAll();
            ViewBag.ProductType = productTypeService.GetAll();
            var data = productService.Read(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult UpdateProduct(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
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
            if(Guid.TryParse(fc["Id"], out guid))
            {
                var data = productService.Read(guid);
                if (data != null)
                {
                    return RedirectToAction("UpdateProduct", "Product", new { Id = fc["Id"] });
                }
                else return View().WithDanger("Lỗi", "Không tìm thấy sản phẩm");
            }
            else return View().WithDanger("Lỗi", "Vui lòng nhập đúng định dạng");
        }


    }
}
