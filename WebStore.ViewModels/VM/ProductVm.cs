namespace WebStore.ViewModels.VM
{
    public class ProductVm
    {
        public int Id { get; set; }
        public int? SupplierId { get; set; }
        public SupplierVm Supplier { get; set; }
        public CategoryVm Category { get; set; }
        public string Description { get; set; }
        public byte[] ImageBytes { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Weight { get; set; }
        public IList<ProductStockVm> ProductStocks { get; set; }
        public IList<OrderVm> Orders { get; set; }
    }
}
