using AutoMapper;
using WebStore.Model.DataModels;
using WebStore.ViewModels.VM;
using System.Linq;

namespace WebStore.Services.Configuration.Profiles{
    public class MainProfile : Profile
    {
    public MainProfile()
    {
        //AutoMapper maps

        CreateMap<AddOrUpdateProductVm, Product>();
        CreateMap<Product, AddOrUpdateProductVm>();
        CreateMap<ProductVm, Product>();
        CreateMap<Product, ProductVm>();

    }
}
}