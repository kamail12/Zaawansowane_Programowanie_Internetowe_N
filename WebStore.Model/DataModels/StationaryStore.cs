namespace WebStore.Model.DataModels
{
    public class StationaryStore
    {
        //Properties of relation 'One-to-Many' - 'StationaryStore-to-Address'
        public virtual IList<Address> Address {get; set;} = default!;

        //Properties of relation 'One-to-Many' - 'StationaryStore-to-StationaryStoreEmployee'
        public virtual IList<StationaryStoreEmployee> Employees {get; set;} = default!;
    }
}