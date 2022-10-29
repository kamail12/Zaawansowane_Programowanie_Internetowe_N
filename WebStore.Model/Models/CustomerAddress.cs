using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.Models

{
    public class CustomerAddress : Address
    {
        [ForeignKey("CustomerAdresses")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; } = default!;
    }
}