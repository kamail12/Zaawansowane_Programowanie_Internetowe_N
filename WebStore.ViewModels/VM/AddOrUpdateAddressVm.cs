using System.ComponentModel.DataAnnotations;
namespace WebStore.Model.DataModels
{
    public class AddOrUpdateAddressVm
    {       
        public int? Id {get; set;}

        [Required]
        public string City {get; set;} = default!;
        
        [Required]
        public string Street {get; set;}= default!;
        
        [Required]
        public int ZipCode {get;set;}
    }
}