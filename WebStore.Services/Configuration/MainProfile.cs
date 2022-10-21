using AutoMapper;
using WebStore.Model.DataModels;
using WebStore.ViewModels.VM;

namespace WebStore.Services.Configuration;
public class MainProfile : Profile
{
    public MainProfile()
    {
        CreateMap<AddOrUpdateProductVm, Product>();
        CreateMap<AddressVm, Address>();
        CreateMap<CategoryVm, Category>();
        CreateMap<CustomerAddressVm, CustomerAddress>();
        CreateMap<CustomerVm, Customer>();
        CreateMap<InvoiceVm, Invoice>();
        CreateMap<OrderProductVm, OrderProduct>();
        CreateMap<OrderVm, Order>();
        CreateMap<ProductStockVm, ProductStock>();
        CreateMap<ProductVm, Product>();
        CreateMap<StationaryStoreAddressVm, StationaryStoreAddress>();
        CreateMap<StationaryStoreEmployeeVm, StationaryStore>();
        CreateMap<StationaryStoreVm, StationaryStore>();
        CreateMap<SupplierVm, Supplier>();
        CreateMap<UserVm, User>();
    }

}