using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels;

public class Address
{
    public Customer Customer {get; set;} = default!;
    [ForeignKey("Customer")]

    public int CustomerId {get; set;}
    public string StreetName {get; set;} = default!;
    public int StreetNumber {get; set;} = default!;
    public string City {get; set;} = default!;
    public string PostCode {get; set;} = default!;

    public StationaryStore StationaryStore {get; set;} = default!;
    [ForeignKey("StationaryStore")]
    public int StationaryStoreId {get; set; } 

}