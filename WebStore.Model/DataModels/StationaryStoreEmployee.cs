using System.ComponentModel.DataAnnotations.Schema;
namespace WebStore.Model.DataModels
{
    public class StationaryStoreEmployee : User
    {
        //Properties of relation 'One-to-Many' - 'StationaryStore-to-StationaryStoreEmployee'
        public virtual StationaryStore StationaryStore {get; set;} = default!;              //Navigation property
        [ForeignKey("StationaryStore")]                                                     //Foreign key Attribute
        public int? StationaryStoreId {get; set;}                                           //Foreign key property

        //Model properties
        public float Salary {get; set;}
    }
}