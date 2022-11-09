using System.ComponentModel.DataAnnotations;

namespace Webstore.Model;

public class Invoice {
     //Propeties of relation 'One-to-Many' - 'Invoice-to-Order'
        public virtual IList<Order> Orders {get; set;} = default!;

        //Model propreties
        [Key]
        public int? Id {get; set;}
        public decimal TotalAmount {get; set;}
}