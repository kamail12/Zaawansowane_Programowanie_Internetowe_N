using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class StationaryStore
    {
        public Address StoreAddress { get; set; }

        virtual public IList<StationaryStoreEmployee> Employees { get; set; }

    }
}