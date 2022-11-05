namespace Webstore.Model;

public class Product {
    public string Category {get; set;} = default!;
    public string Description {get; set;} = default!;
    public int Id {get; set;}
    public byte[] ImageBytes {get; set;} = default!;
    public string Name {get; set;} = default!;
    public decimal Price {get; set;}
    public Supplier Supplier {get; set;} = default!;
    public float Weight {get; set;}
}