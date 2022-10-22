namespace WebStore.ViewModels.VM;
public class SupplierVm : UserVm
{
    public virtual IList<ProductVm> Products { get; set; } = default!;
}