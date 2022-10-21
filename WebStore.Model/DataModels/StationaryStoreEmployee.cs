using Microsoft.AspNetCore.Identity;
using System;
namespace WebStore.Model.DataModels
{
    public class StationaryStoreEmployee : User
    {
        public StationaryStore StationaryStore { get; set; }
    }
}