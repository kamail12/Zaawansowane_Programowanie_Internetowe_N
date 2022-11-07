using System.ComponentModel.DataAnnotations;
namespace WebStore.ViewModels.VM

{
    public class AddOrUpdateInvoiceVm
    {
        public int? InvoiceId {get; set;}
        
        public decimal TotalPrice {get; set;} 
        
        public DateTime InvoiceDate { get; set; } 
        public virtual IList<OrderVm> Orders {get; set;} = default!;
    }
}