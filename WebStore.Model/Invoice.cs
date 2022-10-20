namespace WebStore.Model;

public class Invoice
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string IssuedForGuid { get; set; } = default!;
    public string IssuedByGuid { get; set; } = default!;
    public virtual IList<Product> Products { get; set; } = default!;
    public virtual Customer IssuedFor { get; set; } = default!;
}
