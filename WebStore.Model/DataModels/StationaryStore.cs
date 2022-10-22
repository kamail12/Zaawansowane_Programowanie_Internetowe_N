using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class StationaryStore
    {
        [Key]
        public int Id { get; set; }
        public virtual Address Address { get; set; } = default!;
        [ForeignKey("AdressId")]
        public int AddressId { get; set; }
        public virtual StationaryStoreEmployee StoreEmployees { get; set; } = default!;
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public virtual IList<Invoice> Invoices { get; set; } = default!;
    }
}