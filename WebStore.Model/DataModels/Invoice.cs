namespace WebStore.Model.DataModels
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual IList<Order> Orders { get; set; } = default!;
        public int StoreId { get; set; }
    }
}