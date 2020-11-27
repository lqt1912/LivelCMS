using LivelCmsSystem.Services.CustomDataAccess;
using LivelCMSSystem.Core.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivelCmsSystem.Services
{
    public static class CustomServices
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<IAspNetRoleClaimsService, AspNetRoleClaimsService>();

            services.AddTransient<IAspNetRolesService, AspNetRolesService>();

            services.AddTransient<IAspNetUserClaimsService, AspNetUserClaimsService>();

            services.AddTransient<IAspNetUserLoginsService, AspNetUserLoginsService>();

            services.AddTransient<IAspNetUserRolesService, AspNetUserRolesService>();

            services.AddTransient<IAspNetUsersService, AspNetUsersService>();

            services.AddTransient<IAspNetUserTokensService, AspNetUserTokensService>();

            services.AddTransient<IBrandService, BrandService>();

            services.AddTransient<ICustomerService, CustomerService>();

            services.AddTransient<IInvoiceService, InvoiceService>();

            services.AddTransient<IInvoiceDetailService, InvoiceDetailService>();

            services.AddTransient<IInvoiceStatusService, InvoiceStatusService>();

            services.AddTransient<IProductService, ProductService>();

            services.AddTransient<IProductTypeService, ProductTypeService>();

            services.AddTransient<IReceiptService, ReceiptService>();

            services.AddTransient<IDataAccess, DataAccess>();
        }
    }
}
