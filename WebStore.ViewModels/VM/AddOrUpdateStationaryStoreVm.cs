using System.ComponentModel.DataAnnotations;
using WebStore.Model.DataModels;

namespace WebStore.ViewModels.Vm
{
    public class AddOrUpdateStationaryStoreVm
    {
        public int? Id {get; set;}

        [Required]
        public string Name {get; set;} = default!;

        [Required]
        public IList<StationaryStoreAddress>Addresses {get; set;} = default!;
        public IList<StationaryStoreEmployee>Employees {get; set;} = default!;
    }
}