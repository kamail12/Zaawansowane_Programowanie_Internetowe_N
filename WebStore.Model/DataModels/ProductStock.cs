using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class ProductStock
    {
        public int Quantity { get; set; }
        [Key]
        public int Id { get; set; }

        public virtual Product Product { get; set; } = default!;
        [ForeignKey("Product")]
        public int ProductId { get; set; }
    }
}