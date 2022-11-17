namespace WebStore.ViewModels.VM;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class AddressVm
{
    public int Id { get; set; }
    public string Street { get; set; }
    public int Building { get; set; }
    public string City { get; set; }
    public int PostalCode { get; set; }
    public string Country { get; set; }
}
