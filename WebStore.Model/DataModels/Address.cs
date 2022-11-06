using System.ComponentModel.DataAnnotations;
namespace Webstore.Model;

    public abstract class Address
    {       
        [Key]
        public int Id  {get; set;}
        public string City {get; set;} = default!;
        public string Street {get; set;}= default!;
        public int ZipCode {get;set;}
    }
