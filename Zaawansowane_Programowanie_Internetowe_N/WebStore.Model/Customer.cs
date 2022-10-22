namespace WebStore.Model {
    public class Customer: User {
        public virtual IList<Order> Orders {get; set;} = default!;
        public virtual IList<Address> Addresses {get; set;} = default!;
    }
}