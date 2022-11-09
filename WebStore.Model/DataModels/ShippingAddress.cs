using System.ComponentModel.DataAnnotations.Schema;
namespace Webstore.Model
{
    public class ShippingAddress : Address 
    {
        //Properties of relation 'One-to-Many' - 'Customer-to-Address'
        public virtual Customer Customer {get; set;} = default!;      //Navigation property 
        [ForeignKey("Customer")]                                      //Foreign Key Attribute
        public int? CustomerId {get; set;}                            //Foreign key property
    }
}