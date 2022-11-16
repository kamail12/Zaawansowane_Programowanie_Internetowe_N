using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Model.DataModels;

namespace WebStore.ViewModels.Vm
{
    public class AddOrUpdateStationaryStoreVm
    {
        public int? Id {get; set;}

        [Required]
        public string Name {get; set;} = default!;

        
        public IList<StationaryStoreAddress>?Addresses {get; set;} = default!;
        
        public IList<StationaryStoreEmployee>?Employees {get; set;} = default!;
    }
}