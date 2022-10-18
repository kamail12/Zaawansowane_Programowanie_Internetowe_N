namespace WebStore.Model.DataModel;

public class Invoice
{
    public int invoiceID { get; set; }
    public decimal totalPrice { get; set; }
    public DateTime invoiceDate { get; set; }
    public virtual IList<Order> Orders { get; set; } = default!;
}
