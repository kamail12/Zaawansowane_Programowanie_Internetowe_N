using AutoMapper;
using WebStore.Model.DataModels;
using WebStore.Tests.UnitTests;
using WebStore.Tests.Extensions;
using System.Linq;

namespace WebStore.Tests.Configuration.Profiles{
    public class MainProfile : Profiles
    {
        public MainProfile()
        {
            object value = CreateMap<AddOrUpdateProductVM, ProductVM>();
        }
    }
}