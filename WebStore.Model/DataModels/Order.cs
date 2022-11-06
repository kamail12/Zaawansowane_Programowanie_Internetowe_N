using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webstore.Model;

public class Order {
    //Relation one to many Oder => Customer
    public virtual Customer Customer {get; set;} = default!;
    [ForeignKey("Customer")]                                            
    public int? CustomerId {get; set;}                                 
    
    
    public DateTime DeliveryDate {get; set;}
    public int Id {get; set;}
    public DateTime OrderDate {get; set;}
    public decimal TotalAmount {get;}
    public long TrackingNumber {get; set;}
    
    //Ralation 'Many-to-Many' - 'Order-to-Product'
    public virtual IList<OrderProduct> OrderProducts {get; set;} = default!;
}