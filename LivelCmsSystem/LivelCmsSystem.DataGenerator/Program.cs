using LivelCMSSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LivelCmsSystem.DataGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<ProductType> productTypes = new List<ProductType>()
            {
                new ProductType
                {
                    Id= Guid.Parse("2c737a65-0e99-4afb-8364-e83588554b0c"),
                    ProductTypeName="Xe đạp",
                    CreatedDate= DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new ProductType
                {
                    Id=Guid.Parse("6d5fbd67-7690-4be8-b0d8-94c7bffbf3cb"),
                    ProductTypeName ="Xe máy",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new ProductType
                {
                    Id = Guid.Parse("ae48c81c-d53b-4231-9dab-49fab8c5026a"),
                    ProductTypeName = "Xe máy điện",
                    CreatedDate =DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                 new ProductType
                {
                    Id = Guid.Parse("c0b55282-7926-412c-b3dd-ce3f25095337"),
                    ProductTypeName = "Xe đạp điện",
                    CreatedDate =DateTime.Now,
                    ModifiedDate = DateTime.Now
                }
            };
            List<Brand> brands = new List<Brand>()
            {
                new Brand
                {
                    Id =Guid.Parse("7dc4d627-8797-47aa-a525-cf346353bf8f"),
                    BrandName="Vinfast",
                    CreatedDate=DateTime.Now,
                    ModifiedDate =DateTime.Now
                },
                 new Brand
                {
                    Id = Guid.Parse("7bfd18fc-9d00-49f3-b418-2bb156660fbd"),
                    BrandName="Thaco",
                    CreatedDate=DateTime.Now,
                    ModifiedDate =DateTime.Now
                },
                  new Brand
                {
                    Id = Guid.Parse("e32356ca-d0ac-42f5-a8df-96df5f538d67"),
                    BrandName="Martin",
                    CreatedDate=DateTime.Now,
                    ModifiedDate =DateTime.Now
                },
                   new Brand
                {
                    Id = Guid.Parse("16e2b4b5-fead-4acf-b079-4ea9869bdea3"),
                    BrandName="Wave",
                    CreatedDate=DateTime.Now,
                    ModifiedDate =DateTime.Now
                },
                    new Brand
                {
                    Id = Guid.Parse("dbba6830-2fb4-4467-be27-8ad115b89ab9"),
                    BrandName="Honda",
                    CreatedDate=DateTime.Now,
                    ModifiedDate =DateTime.Now
                }
            };
            List<Product> products = new List<Product>() {
            new Product{
                Id = Guid.NewGuid(),
                Name="Xe máy điện Vinfast 1",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Vinfast").Id,
                UnitPrice = 20000000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy điện").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            }, 
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy điện Vinfast 2",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Vinfast").Id,
                UnitPrice = 30000000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy điện").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy điện Vinfast 3",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Vinfast").Id,
                UnitPrice = 15000000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy điện").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe đạp Martin 1",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Martin").Id,
                UnitPrice = 1500000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe đạp").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe đạp Martin 2",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Martin").Id,
                UnitPrice = 2000000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe đạp").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe đạp Martin 3",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Martin").Id,
                UnitPrice = 4000000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe đạp").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy Thaco 1",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Thaco").Id,
                UnitPrice = 20000000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy Thaco 2",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Thaco").Id,
                UnitPrice = 30000000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy Thaco 3",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Thaco").Id,
                UnitPrice = 40000000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy điện Honda 1",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Honda").Id,
                UnitPrice = 2000000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy điện").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy điện Honda 2",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Honda").Id,
                UnitPrice = 20000000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy điện").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy điện Honda 3",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Honda").Id,
                UnitPrice = 50000000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy điện").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy điện Honda 4",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Honda").Id,
                UnitPrice = 6000000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy điện").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            }, 
            new Product{
                Id = Guid.NewGuid(),
                Name="Xe máy điện Vinfast 1",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Vinfast").Id,
                UnitPrice = 45000000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy điện").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy điện Vinfast 2",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Vinfast").Id,
                UnitPrice = 32100000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy điện").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy điện Vinfast 3",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Vinfast").Id,
                UnitPrice = 11200000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy điện").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe đạp Martin 1",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Martin").Id,
                UnitPrice = 1540000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe đạp").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe đạp Martin 2",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Martin").Id,
                UnitPrice = 21230000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe đạp").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe đạp Martin 3",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Martin").Id,
                UnitPrice = 40232000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe đạp").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy Thaco 1",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Thaco").Id,
                UnitPrice = 20034000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy Thaco 2",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Thaco").Id,
                UnitPrice = 30003300,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy Thaco 3",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Thaco").Id,
                UnitPrice = 40220000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy điện Honda 1",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Honda").Id,
                UnitPrice = 21120000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy điện").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy điện Honda 2",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Honda").Id,
                UnitPrice = 20120000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy điện").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy điện Honda 3",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Honda").Id,
                UnitPrice = 50234000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy điện").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Product
            {
                 Id = Guid.NewGuid(),
                Name="Xe máy điện Honda 4",
                Brand= brands.SingleOrDefault(x=>x.BrandName=="Honda").Id,
                UnitPrice = 6012000,
                ProductType = productTypes.SingleOrDefault(x=>x.ProductTypeName =="Xe máy điện").Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            }
            };
            List<Customer> customers = new List<Customer>()
            {
                new Customer
                {
                    Id= Guid.NewGuid(),
                    Name="Đại lý số 1",
                    Address="Quận 7, TP HCM",
                    PhoneNumber="+84235678765",
                    Email="dailysomot@gmail.com",
                    CreatedDate=DateTime.Now,
                    ModifiedDate =DateTime.Now
                },
                 new Customer
                {
                    Id= Guid.NewGuid(),
                    Name="Đại lý số 2",
                    Address="Quận Hải Châu, Đà Nẵng",
                    PhoneNumber="+84235678769",
                    Email="dailydanang@gmail.com",
                    CreatedDate=DateTime.Now,
                    ModifiedDate =DateTime.Now
                },
                  new Customer
                {
                    Id= Guid.NewGuid(),
                    Name="Cửa hàng Bình Dân",
                    Address="H. Châu Thành, Tây Ninh",
                    PhoneNumber="+84235678769",
                    Email="binhdanshop@gmail.com",
                    CreatedDate=DateTime.Now,
                    ModifiedDate =DateTime.Now
                },
                     new Customer
                {
                    Id= Guid.NewGuid(),
                    Name="Cửa hàng Hồng Hoa",
                    Address="H. Châu Thành, Tiền Giang",
                    PhoneNumber="+84235678769",
                    Email="rosingshop@gmail.com",
                    CreatedDate=DateTime.Now,
                    ModifiedDate =DateTime.Now
                },
            };

            List<InvoiceStatus> invoiceStatuses = new List<InvoiceStatus>()
            {
                new InvoiceStatus
                {
                    Id =Guid.NewGuid(),
                    Name="Đã thanh toán",
                    CreatedDate=DateTime.Now,
                    ModifiedDate =DateTime.Now
                },
                new InvoiceStatus
                {
                    Id =Guid.NewGuid(),
                    Name="Chưa thanh toán",
                    CreatedDate=DateTime.Now,
                    ModifiedDate =DateTime.Now
                },
                new InvoiceStatus
                {
                    Id =Guid.NewGuid(),
                    Name="Còn nợ",
                    CreatedDate=DateTime.Now,
                    ModifiedDate =DateTime.Now
                },
                new InvoiceStatus
                {
                    Id =Guid.NewGuid(),
                    Name="Đã hủy",
                    CreatedDate=DateTime.Now,
                    ModifiedDate =DateTime.Now
                },
            };
            //foreach (var item in productTypes)
            //{
            //    var str = $"insert into ProductType values('{item.Id}', N'{item.ProductTypeName}','{item.CreatedDate}', '{item.ModifiedDate}' )";
            //    Console.WriteLine(str);
            //}

            //foreach (var item in brands)
            //{
            //    var str = $"insert into Brand values('{item.Id}', N'{item.BrandName}','{item.CreatedDate}', '{item.ModifiedDate}' )";
            //    Console.WriteLine(str);
            //}

            //foreach (var item in products)
            //{
            //    var str = $"insert into Product values('{item.Id}', N'{item.Name}','{item.Brand}', '{item.UnitPrice}','{item.ProductType}', '{item.CreatedDate}', '{item.ModifiedDate}' )";
            //     Console.WriteLine(str);
            //}
            //foreach (var item in customers)
            //{
            //    var str = $"insert into Customer values('{item.Id}', N'{item.Name}',N'{item.Address}', '{item.PhoneNumber}','{item.Email}', '{item.CreatedDate}', '{item.ModifiedDate}' )";
            //        Console.WriteLine(str);
            //}
            foreach (var item in invoiceStatuses)
            {
                var str = $"insert into InvoiceStatus values('{item.Id}', N'{item.Name}', '{item.CreatedDate}', '{item.ModifiedDate}' )";
                Console.WriteLine(str);
            }
        }
    }
}