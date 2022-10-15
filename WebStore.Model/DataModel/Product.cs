using Microsoft.AspNetCore.Identity;
namespace WebStore.Model.DataModel
{
    public class Product
    {
        public Category Category { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Id { get; set; } = default!;
        public string ImageBytes { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Price { get; set; } = default!;
        public string Supplier { get; set; } = default!;
        public string Weight { get; set; } = default!;

    }
}