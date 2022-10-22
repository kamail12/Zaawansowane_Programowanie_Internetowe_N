namespace WebStore.Model.DataModels
{
    public abstract class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Type { get; set; } = default!;
        public virtual IList<Product> Products { get; set; } = default!;
    }
}