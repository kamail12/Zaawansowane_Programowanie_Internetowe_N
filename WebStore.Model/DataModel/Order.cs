namespace WebStore.Model.DataModel;

public class Order
{
    public Customer Customer { get; set; } = default!;
    public int Id { get; set; } = default!;

    public DateTime OrderDate { get; set; } = default!;

   public Invoice Invoice { get; set; } = default!;
}
