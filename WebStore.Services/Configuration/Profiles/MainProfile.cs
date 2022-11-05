using AutoMapper;
using WebStore.Model.DataModels;
using WebStore.ViewModels.Vm;
namespace WebStore.Services.Configuration.Profiles
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {
            //AutoMapper maps
            //Product maps
            CreateMap<Product, ProductVm>(); //map from Product(src) to ProductVm(dst)
            CreateMap<AddOrUpdateProductVm, Product>();
            CreateMap<ProductVm, AddOrUpdateProductVm>();    
            
            //Order maps
            CreateMap<Order, OrderVm>(); //map from Order(src) to OrderVm(dst)
            CreateMap<AddOrUpdateOrderVm, Order>();
            CreateMap<OrderVm, AddOrUpdateOrderVm>();    

            //Invoice maps
            CreateMap<Invoice, InvoiceVm>(); //map from Invoice(src) to InvoiceVm(dst)
            CreateMap<AddOrUpdateInvoiceVm, Invoice>();
            CreateMap<InvoiceVm, AddOrUpdateInvoiceVm>();  
        }
    }
}