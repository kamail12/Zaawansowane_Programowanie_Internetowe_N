namespace WebStore.Model;

public class Address
{
    public int Id { get; set; }
    public string PostalCode { get; set; } = default!;

    public string City { get; set; } = default!;

    public string Street { get; set; } = default!;

    public string Country { get; set; } = default!;
}
