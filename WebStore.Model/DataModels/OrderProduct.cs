using System;

namespace WebStore.Model.DataModels
{
    public class OrderProduct
    {
        public Order Order {get; set;} = default!;
        public Product Product {get; set;} = default!;
        public int Quantity {get; set;}
    }
}