using System.ComponentModel.DataAnnotations;

namespace WebStore.ViewModels.VM
{
    public class AddOrUpdateAddressVm
    {
        public int? Id { get; set; }

        [Required]
        public string StreetName { get; set; } = default!;
        [Required]
        public string City { get; set; } = default!;
    }
}