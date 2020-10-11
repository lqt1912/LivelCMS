using LivelCMSSystem.Core.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivelCmsSystem.Services
{
    public static class CustomRepository
    {
        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddTransient<IAspNetRolesClaimsRepository, AspNetRoleClaimsRepository>();

            services.AddTransient<IAspNetRolesRepository, AspNetRolesRepository>();

            services.AddTransient<IAspNetUserClaimsRepository, AspNetUserClaimsRepository>();

            services.AddTransient<IAspNetUserLoginsRepository, AspNetUserLoginsRepository>();

            services.AddTransient<IAspNetUserRolesRepository, AspNetUserRolesRepository>();

            services.AddTransient<IAspNetUsersRepository, AspNetUsersRepository>();

            services.AddTransient<IAspNetUserTokensRepository, AspNetUserTokensRepository>();

            services.AddTransient<IBrandRepository, BrandRepository>();

            services.AddTransient<ICustomerRepository, CustomerRepository>();

            services.AddTransient<IInvoiceRepository, InvoiceRepository>();

            services.AddTransient<IInvoiceDetailRepository, InvoiceDetailRepository>();

            services.AddTransient<IInvoiceStatusRepository, InvoiceStatusRepository>();

            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddTransient<IProductTypeRepository, ProductTypeRepository>();

            services.AddTransient<IReceiptRepository, ReceiptRepository>();
        }
    }
}
