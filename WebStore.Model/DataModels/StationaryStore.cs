using Microsoft.AspNetCore.Identity;
using System;
namespace WebStore.Model.DataModels
{
    public class StationaryStore
    {
        public virtual IList<Address> Addresses { get; set; }
        public virtual IList<StationaryStoreEmployee> StationaryStoreEmployees { get; set; }
    }
}