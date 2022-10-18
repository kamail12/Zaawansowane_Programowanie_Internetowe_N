namespace WebStore.Model.Models;
public class Address
{
    public int Id { get; set; }
    public string City { get; set; } = default!;
    public string StreetName { get; set; } = default!;
    public int StreetNumber { get; set; } = default!;
    public string PostCode { get; set; } = default!;
    public int? StationaryStoreId { get; set; }
    public virtual StationaryStore? StationaryStore { get; set; }
    public int? CustomerId { get; set; }
    public virtual Customer? Customer { get; set; }

}