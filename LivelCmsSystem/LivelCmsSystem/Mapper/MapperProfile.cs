using AutoMapper;
using LivelCMSSystem.Core.Models;
using LivelCMSSystem.Models;

namespace LivelCmsSystem.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AspNetRoleClaims, AspNetRoleClaimsViewModel>().ReverseMap();
            CreateMap<AspNetRoleClaims, AspNetRoleClaimsViewModel>().ReverseMap();
            CreateMap<AspNetRoles, AspNetRolesViewModel>().ReverseMap();
            CreateMap<AspNetUserClaims, AspNetUserClaimsViewModel>().ReverseMap();
            CreateMap<AspNetUserLogins, AspNetUserLoginsViewModel>().ReverseMap();
            CreateMap<AspNetUserRoles, AspNetUserRolesViewModel>().ReverseMap();
            CreateMap<AspNetUsers, AspNetUsersViewModel>().ReverseMap();
            CreateMap<AspNetUserTokens, AspNetUserTokensViewModel>().ReverseMap();
            CreateMap<Brand, BrandViewModel>().ReverseMap();
            CreateMap<Customer, CustomerViewModel>().ReverseMap();
            CreateMap<InvoiceDetail, InvoiceDetailViewModel>().ReverseMap();
            CreateMap<InvoiceStatus, InvoiceStatusViewModel>().ReverseMap();
            CreateMap<Invoice, InvoiceViewModel>().ReverseMap();
            CreateMap<ProductType, ProductViewModel>().ReverseMap();
            CreateMap<Product  , ProductViewModel>().ReverseMap();
            CreateMap<Receipt   , ReceiptViewModel>().ReverseMap();
            CreateMap<AspNetUserTokens, AspNetUserTokensViewModel>().ReverseMap();
        }
    }
}
