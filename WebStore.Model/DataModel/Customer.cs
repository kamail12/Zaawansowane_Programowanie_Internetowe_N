using Microsoft.AspNetCore.Identity;
namespace WebStore.Model.DataModel
{
    public class Customer : User
    {

        public Address BillingAddress { get; set; } = default!;
        public IList<Order> Orders { get; set; } = default!;
        public Address ShippingAddress { get; set; } = default!;

      
    }
}