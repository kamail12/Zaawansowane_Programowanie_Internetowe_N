using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebStore.Model.DataModels
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public int PostalCode { get; set; }
        public int Building { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set;}
        
    }
}