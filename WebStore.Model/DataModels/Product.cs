using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebStore.Model.DataModels
{
    public class Product
    {
        //Properties of realation 'One-to-Many'-'Supplier-to-Product'
        public virtual Supplier Supplier {get; set;} = default!;                              //Navigation property
        [ForeignKey("Supplier")]                                                              //Foreign key attribute  
        public int? SupplierId {get; set;}                                                    //Foreign key property

        //Properties of relation 'One-to-Many' - 'Product-to-ProductStock'
        public virtual IList<ProductStock> ProductStocks {get; set;} = default!;

        //Properties of relation 'One-to-Many' - 'Category-to-Product'
        public virtual Category Category {get; set;} = default!;                               //Navigation property
        [ForeignKey("Category")]                                                               //Foreign key attribute
        public virtual int? CategoryId {get; set;}                                             //Foreign key property

        //Properties of relation 'Many-to-Many' - 'Order-to-Product'
        public virtual IList<OrderProduct> OrderProducts {get; set;} = default!;

        //Model properties
        public string Description {get; set;} = default!;
        [Key]
        public int? Id {get; set;}
        public byte[] ImageBytes {get; set;} = default!;
        public string Name {get; set;} = default!;
        public decimal Price {get; set;}
        public float Weight {get; set;}
        //public int Quantity{get; set;}
    }
}