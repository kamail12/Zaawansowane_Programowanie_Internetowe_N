using System.ComponentModel.DataAnnotations;
namespace Webstore.Model
{
    public class StationaryStore
    {
        //Relation 'One-to-Many' - 'StationaryStore => Address'
        public virtual IList<Address> Addresses {get; set;} = default!;
        
        //Relation 'One-to-Many' - StationaryStore => StationaryStoreEmployee
        public virtual IList<StationaryStoreEmployee> Employees {get; set;} = default!;

        [Key]
        public int? Id {get; set;}
        public string Name {get; set;} = default!; 
    }
}