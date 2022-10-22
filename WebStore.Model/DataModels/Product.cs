namespace WebStore.Model.DataModels
{
    public class Product 
    {
        public string Description { get; set; } = default!;
        public int Id{ get; set; }
        public byte[] ImageBytes { get; set; } = default!;
        public string Name { get; set; } = default!;
        public decimal Price{ get; set; }
        public virtual Supplier Supplier { get; set; } = default!;
        public float Weight { get; set; }
        public virtual Category Category { get; set; } = default!;
        public virtual IList<ProductStock> ProductStocks { get; set; } = default!;
    }
}