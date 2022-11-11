using WebStore.Model.DataModels;

namespace WebStore.ViewModels.Vm
{
    public class InvoiceVm
    {
        public decimal TotalAmount {get; set;}

        public virtual IList<Order> Orders {get; set;} = default!;
    }
}