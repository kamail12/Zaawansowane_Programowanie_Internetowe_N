namespace WebStore.Model;

public class Invoice
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string IssuedForGuid { get; set; }
    public string IssuedByGuid { get; set; }
    public virtual IList<Product> Products { get; set; }
    public virtual Customer IssuedFor { get; set; }
}
