namespace WebStore.Model.DataModels
{
    public class StationaryStore
    {
        public Address Address {get; set;}
        public IList<StationaryStoreEmployee> Employees {get; set;}
    }
}