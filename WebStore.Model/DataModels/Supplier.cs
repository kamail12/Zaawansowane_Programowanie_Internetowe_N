namespace WebStore.Model.DataModels
{
    public class Supplier : User
    {
        //Properties of relation 'One-to-many' - 'Supplier-to-Product'
        public virtual IList<Product> Products{get; set;} = default!;
    }
}