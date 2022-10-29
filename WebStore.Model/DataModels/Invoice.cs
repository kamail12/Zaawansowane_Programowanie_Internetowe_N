namespace WebStore.Model.DataModels
{
    public class Invoice
    {
        //Propeties of relation 'One-to-Many' - 'Invoice-to-Order'
        public virtual IList<Order> Orders {get; set;} = default!;

        //Model propreties
        public decimal TotalAmount {get; set;}
    }
}