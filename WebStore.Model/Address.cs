namespace WebStore.Model;

public class Address
{
    public int Id { get; set; }
    public string BuildingNumber { get; set; } = default!;
    public int? ApartmentNumber { get; set; }
    public string Town { get; set; } = default!;
    public string ZipCode { get; set; } = default!;
    public string Country { get; set; } = default!;
}
