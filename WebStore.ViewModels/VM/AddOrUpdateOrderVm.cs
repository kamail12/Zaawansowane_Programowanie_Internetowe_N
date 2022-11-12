using System.ComponentModel.DataAnnotations;
namespace WebStore.ViewModels.Vm
{
    public class AddOrUpdateOrderVm
    {
        public int? Id {get; set;}       
        public int? CustomerId {get; set;}
        public int? InvoiceId {get; set;}

        [Required]       
        public DateTime DeliveryDate {get; set;}

        [Required]
        public DateTime OrderDate {get; set;}

        [Required]
        public long TrackingNumber {get; set;}
        
         
    }
}