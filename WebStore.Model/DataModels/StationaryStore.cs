using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.DataModels
{
    public class StationaryStore
    {
        public Address Address { get; set; } = default!;

        public IList<StationeryStoreEmployee> StationeryStoreEmployees { get; set; } = default!;
    }
}