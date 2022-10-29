using System;

namespace WebStore.Model.DataModels
{
    public class OrderProduct
    {
        //Properties of relatiorn 'Many-to-Many' - 'Order-to-Product' 
        public virtual Order Order {get; set;} = default!;
        public int? OrderId {get; set;}
        public virtual Product Product {get; set;} = default!;
        public int? ProductId {get; set;}

        //Model properties
        public int Quantity {get; set;}
    }
}