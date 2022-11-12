using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class Invoice
    {
        //Propeties of relation 'One-to-Many' - 'Invoice-to-Order'
        public virtual IList<Order> Orders {get; set;} = default!;

        //Model propreties
        [Key]
        public int Id {get; set;}
        
        [Column(TypeName = "decimal(12, 2)")]
        public decimal TotalAmount {get; set;}
    }
}