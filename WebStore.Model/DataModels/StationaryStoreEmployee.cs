using Microsoft.AspNetCore.Identity;
using System;

namespace WebStore.Model.DataModels
{
    public class StationaryStoreEmployee : User
    {
        public string Position { get; set; }

        public StationaryStore StationaryStore { get; set; }

        public int StationaryStoreId { get; set; }

        public float Salary { get; set; }
    }
}