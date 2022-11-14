using System.ComponentModel.DataAnnotations;
using Webstore.Model;

namespace WebStore.ViewModels.Vm
{
    public class AddOrUpdateStationaryStoreVm
    {
        public int? Id {get; set;}

        [Required]
        public string Name {get; set;} = default!;

        [Required]
        public IList<Address>Addresses {get; set;} = default!;
    }
}