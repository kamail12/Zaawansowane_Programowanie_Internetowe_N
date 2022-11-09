namespace Webstore.Model;

public class Customer : User {
    
     /*Clas 'one' to create correctly relations must be declarate the list of referatons of class "many"
        It must be virtual object*/

        //Properties of relation 'One-to-many' - 'Customer-to-Address'
        public virtual IList<BillingAddress> BillingAddress {get; set;} = default!;
        public virtual IList<ShippingAddress> ShippingAddress {get; set;} = default!;
        
        //Properties of relation 'One-to-many' - 'Customer-to-Order'
        public virtual IList<Order> Orders {get; set;} = default!;
}