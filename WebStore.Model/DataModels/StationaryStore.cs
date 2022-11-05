using System.ComponentModel.DataAnnotations;
namespace WebStore.Model.DataModels
{
    public class StationaryStore
    {
        //Properties of relation 'One-to-Many' - 'StationaryStore-to-Address'
        public virtual IList<StationaryStoreAddress> Addresses {get; set;} = default!;

        //Properties of relation 'One-to-Many' - 'StationaryStore-to-StationaryStoreEmployee'
        public virtual IList<StationaryStoreEmployee> Employees {get; set;} = default!;

        //Model properties
        [Key]
        public int? Id {get; set;}
        public string Name {get; set;} = default!; 
    }
}