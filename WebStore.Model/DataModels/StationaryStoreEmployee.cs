using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webstore.Model;

public class StationaryStoreEmployee : User {
      
        //Relation 'One-to-Many' - StationaryStore => StationaryStoreEmployee
        //Navigation property
        public virtual StationaryStore StationaryStore {get; set;} = default!; 
        [ForeignKey("StationaryStore")]
        public int StationaryStoreId {get; set;}

        //Model properties
        public float Salary {get; set;}
}