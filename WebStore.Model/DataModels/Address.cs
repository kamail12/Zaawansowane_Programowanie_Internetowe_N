using System.ComponentModel.DataAnnotations;
namespace WebStore.Model.DataModels
{
    public abstract class Address
    {       
        //Model properties
        [Key]
        public int? Id {get; set;}
        public string City {get; set;} = default!;
        public string Street {get; set;}= default!;
        public int ZipCode {get;set;}
    }
}