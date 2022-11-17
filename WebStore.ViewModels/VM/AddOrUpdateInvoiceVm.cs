using System.ComponentModel.DataAnnotations;
namespace WebStore.ViewModels.VM

{
    public class AddOrUpdateInvoiceVm
    {
        public int? Id { get; set; }

        [Required]
        public int InvoiceId { get; set; }

        [Required]
        public decimal TotalAmount  { get; set; } 
    }
}