using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebStore.ViewModels.VM
{
    public class AddOrUpdateAddressVm
    {
        public int? Id { get; set; }
        [Required]
        public string Country { get; set; } = default!;
        [Required]
        public string City { get; set; } = default!;
        [Required]
        public int BuildingNumber { get; set; }
        [Required]
        public string PostalCode { get; set; } = default!;

    }
}