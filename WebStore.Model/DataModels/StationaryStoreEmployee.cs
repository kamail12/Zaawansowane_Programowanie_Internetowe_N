using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels;

public class StationaryStoreEmployee : User
{
    public int AggrementNumber {get; set;}
    public DateTime Employment {get; set;}
    public string Position {get; set;} = default !;
    public string Salary {get; set;} = default !;
    public virtual StationaryStore StationaryStore {get; set;} = default !;
    [ForeignKey("StationaryStore")]
    public int StationaryStoreId {get; set;} = default!;
}