using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebStore.Model.DataModels
{
    public class Order
    {
        //Needes to create relation one-to-many
        //Class 'many'
        //Properties of realation 'One-to-Many'-'Customer-to-Order'
        public virtual Customer Customer {get; set;} = default!;            //"Navigation property"contain referance to 'one' object
        [ForeignKey("Customer")]                                            //"Foreign key attribute" 
        public int? CustomerId {get; set;}                                  //"Foreign key property"

        //Propeties of relation 'One-to-Many' - 'Invoice-to-Order'
        public virtual Invoice Invoice {get; set;} = default!;              //"Navigation property"contain referance to 'one' object
        [ForeignKey("Invoice")]                                             //"Foreign key attribute" 
        public int? InvoiceId {get; set;}                                   //"Foreign key property"

        //Properties of relation 'Many-to-Many' - 'Order-to-Product'
        public virtual IList<OrderProduct> OrderProducts {get; set;} = default!;

        //Model Properties
        public DateTime DeliveryDate {get; set;}
        [Key]
        public int? Id {get; set;}                                          //"Main key"
        public DateTime OrderDate {get; set;}
        public long TrackingNumber {get; set;}
    }
}