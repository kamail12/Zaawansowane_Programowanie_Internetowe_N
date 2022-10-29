using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebStore.Model.DataModels
{
    public class ProductStock
    {
        //Properties of relation 'One-to-Many' - 'Product-to-ProductStock'
        public virtual Product Product {get; set;} = default!;          //Property Navigation
        [ForeignKey("Product")]                                         //Foreign Key Attribute
        public int? ProductId {get; set;}                               //Foreign Key property

        //Model properties
        [Key]
        public int? Id {get; set;}
        public int Quantity {get; set;}
    }
} 