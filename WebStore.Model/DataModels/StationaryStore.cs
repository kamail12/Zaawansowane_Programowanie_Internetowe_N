using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class StationaryStore
    {
        //Properties of relation 'One-to-Many' - 'StationaryStore-to-Address'
        [NotMapped]
        public virtual IList<StationaryStoreAddress> Addresses {get; set;} = default!;

        //Properties of relation 'One-to-Many' - 'StationaryStore-to-StationaryStoreEmployee'
        [NotMapped]
        public virtual IList<StationaryStoreEmployee> Employees {get; set;} = default!;

        //Model properties
        [Key]
        public int Id {get; set;}
        public string Name {get; set;} = default!; 
    }
}