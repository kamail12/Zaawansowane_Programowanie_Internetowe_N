namespace WebStore.ViewModels.VM
{
    public class OrderProductVm
    {
        public int Id { get; set; }
        public virtual OrderVm Order { get; set; } = default!;
        public int OrderId { get; set; }
        public virtual ProductVm Product { get; set; } = default!;
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}