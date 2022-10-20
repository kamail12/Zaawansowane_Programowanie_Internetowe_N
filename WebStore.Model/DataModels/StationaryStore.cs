using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class StationaryStore
    {
        public virtual Address? Address { get; set; }
        public virtual IList<StationaryStoreEmployee>? Employees { get; set; }
    }
}