using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class StationaryStoreEmployee : User
    {
        public string Position { get; set; } = default!;

        public StationaryStore StationaryStore { get; set; } = default!;

        public int StationaryStoreId { get; set; } = default!;

        public float Salary { get; set; } = default!;
    }
}