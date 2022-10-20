using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels;

public class Address
{
    [Key]
    public int Id { get; set; }
    public virtual Customer Customer { get; set; } = default!;
    [ForeignKey("Customer")]
    public int? CustomerId { get; set; }
    public virtual StationaryStore Store { get; set; } = default!;
    [ForeignKey("Store")]
    public int? StoreId { get; set; }
    public string BuildingNumber { get; set; } = default!;
    public int? ApartmentNumber { get; set; }
    public string Town { get; set; } = default!;
    public string ZipCode { get; set; } = default!;
    public string Country { get; set; } = default!;
}
