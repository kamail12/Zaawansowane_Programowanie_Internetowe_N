using System.ComponentModel.DataAnnotations;

namespace WebStore.ViewModels.Vm
{
    public class AddOrUpdateStationaryStoreVm
    {
        public int? Id {get; set;}

        [Required]
        public string Name {get; set;} = default!;

        //[Required]
        //public IList<Address>Addresses {get; set;}
        //public IList<Employee>Employees {get; set;}
    }
}