using System.ComponentModel.DataAnnotations.Schema;
namespace WebStore.Model.DataModels
{
    public class Address
    {
        //Properties of relation 'One-to-Many' - 'Customer-to-Address'
        public virtual Customer Customer {get; set;} = default!;      //Navigation property 
        [ForeignKey("Customer")]                                      //Foreign Key Attribute
        public int? CustomerId {get; set;}                    //Foreign key property
        
        //Properties of relation 'One-to-Many' - 'StationaryStore-to-Address'
        public virtual StationaryStore StationaryStore {get; set;} = default!;      //Navigation property 
        [ForeignKey("StationaryStore")]                                             //Foreign Key Attribute
        public int? StationaryStoreId {get; set;}                           //Foreign key property
        
        
        //Model properties
        public string City {get; set;} = default!;
        public string Street {get; set;}= default!;
        public int ZipCode {get;set;}
    }
}