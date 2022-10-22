namespace WebStore.Model.DataModels
{
    public class StationaryStore
    {
        public int Id { get; set; }
        public virtual Address Address { get; set; } = default!;
        public virtual IList<StationaryStoreEmployee> Employees { get; set; } = default!;
        public virtual IList<Invoice> Invoices { get; set; } = default!;
    }
}