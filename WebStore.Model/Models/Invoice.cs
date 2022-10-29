using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal totalPrice {get; set;} 
        public virtual IList<Order> Orders { get; set; } = default!;
    }
}