namespace WebStore.ViewModels.VM;
public class CustomerVm : UserVm
{
    public virtual IList<BillingAddressVm> BillingAddresses { get; set; } = default!;
    public virtual IList<ShippingAddressVm> ShippingAddresses { get; set; } = default!;
    public virtual IList<OrderVm> Orders { get; set; } = default!;
}