namespace WebStore.Model.DataModels
{
    public class StationaryStoreEmployee 
    {
        public string FirstName { get; set; } = default!;
       public string LastName { get; set; } = default!;
       public int EmployeeID { get; set; }
       public virtual StationaryStore StationaryStore { get; set; } = default!;

    }
}