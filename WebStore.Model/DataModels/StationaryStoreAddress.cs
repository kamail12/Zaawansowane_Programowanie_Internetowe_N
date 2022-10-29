using System.ComponentModel.DataAnnotations.Schema;
namespace WebStore.Model.DataModels
{
    public class StationaryStoreAddress : Address 
    {
        //Properties of relation 'One-to-Many' - 'StationaryStore-to-Address'
        public virtual StationaryStore StationaryStore {get; set;} = default!;      //Navigation property 
        [ForeignKey("StationaryStore")]                                             //Foreign Key Attribute
        public int? StationaryStoreId {get; set;}                           //Foreign key property
    }
}