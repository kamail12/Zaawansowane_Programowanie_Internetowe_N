using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebStore.Model.DataModels
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string IssuedForGuid { get; set; }
        public string IssuedByGuid { get; set; }
        public virtual IList<Product> Products { get; set; }
        public virtual IList<Order> Orders { get; set; }
        public virtual Customer IssuedFor { get; set; }
    }
}

