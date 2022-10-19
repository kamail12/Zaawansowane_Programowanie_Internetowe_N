namespace WebStore.Model.Models;
public class BillingAddressVm : AddressVm
{
    public int CustomerId { get; set; }
    public CustomerVm Customer { get; set; } = default!;
}
