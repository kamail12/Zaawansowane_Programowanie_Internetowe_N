namespace WebStore.Model.DataModels
{
    public class ProductStock
    {
        public int Id { get; set; }
        public virtual Product Product { get; set; } = default!;
        public int Quantity { get; set; }
        public int ProductId { get; set; }
    }
}