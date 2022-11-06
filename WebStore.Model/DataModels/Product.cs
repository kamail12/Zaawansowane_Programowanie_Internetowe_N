using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webstore.Model;

public class Product {
    //Relation one to many Supplier => Product
    public virtual Supplier Supplier {get; set;} = default!; 
    [ForeignKey("Supplier")]
    public int? SupplierId {get; set;}


    public string Category {get; set;} = default!;
    public string Description {get; set;} = default!;
    public int Id {get; set;}
    public byte[] ImageBytes {get; set;} = default!;
    public string Name {get; set;} = default!;
    public decimal Price {get; set;}
    //public Supplier Supplier {get; set;} = default!;
    public float Weight {get; set;}

    //Relation 'Many-to-Many' - 'Order-to-Product'
    public virtual IList<OrderProduct> OrderProducts {get; set;} = default!;
}