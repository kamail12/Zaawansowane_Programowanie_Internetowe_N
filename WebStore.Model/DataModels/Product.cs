using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class Product 
    {
        public string Description { get; set; } = default!;
        [Key]
        public int Id{ get; set; }
        public byte[] ImageBytes { get; set; } = default!;
        public string Name { get; set; } = default!;
        public decimal Price{ get; set; }
        public virtual Supplier Supplier { get; set; } = default!;
        [ForeignKey("SupplierId")]
        public int SupplierId { get; set; }
        public float Weight { get; set; }
        public virtual Category Category { get; set; } = default!;
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public virtual IList<ProductStock> ProductStocks { get; set; } = default!;

        public virtual IList<OrderProduct> OrderProducts { get; set; } = default!;
    }
}