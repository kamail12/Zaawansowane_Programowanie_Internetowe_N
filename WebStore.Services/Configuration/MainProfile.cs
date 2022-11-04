using AutoMapper;
using WebStore.Model.Models;
using WebStore.ViewModels.VM;


namespace WebStore.Services.Configuration
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {
            CreateMap<AddOrUpdateProductVm, Product>();
            CreateMap<ProductVm, Product>();
            CreateMap<Product, ProductVm>();

            CreateMap<AddOrUpdateOrderVm, Order>();
            CreateMap<OrderVm, Order>();
            CreateMap<Order, OrderVm>();

            CreateMap<AddOrUpdateStoreVm, StationaryStore>();
            CreateMap<StationaryStoreVm, StationaryStore>();
            CreateMap<StationaryStore, StationaryStoreVm>();

            CreateMap<AddOrUpdateInvoiceVm, Invoice>();
            CreateMap<InvoiceVm, Invoice>();
            CreateMap<Invoice, InvoiceVm>();

            CreateMap<AddOrUpdateAddressVm, Address>();
            CreateMap<AddressVm, Address>();
            CreateMap<Address, AddressVm>();

        }
    }
}