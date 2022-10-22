using System.ComponentModel.DataAnnotations;

namespace WebStore.Model.DataModels
{
    public abstract class Address
    {
        [Key]
        public int Id { get; set; }
        public string Conutry { get; set; } = default!;
        public string City { get; set; } = default!;
        public int PostCode { get; set; }
        public string Street { get; set; } = default!;
        public int BuildingNumber { get; set; }
    }

}