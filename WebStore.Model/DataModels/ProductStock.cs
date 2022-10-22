using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class ProductStock
    {
        [Key]
        public int Id { get; set; }
        public virtual Product Product { get; set; } = default!;
        public int Quantity { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
    }
}