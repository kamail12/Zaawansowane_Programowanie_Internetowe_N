using Microsoft.AspNetCore.Identity;

namespace WebStore.Model;

public class StationaryStore
{
   public Adress Adress {get; set;} = default!;
   public IList<Order> Orders {get; set;} = default!;
   
}