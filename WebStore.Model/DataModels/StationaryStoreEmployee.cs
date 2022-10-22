using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class StationaryStoreEmployee 
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        [ForeignKey("StoreId")]
        public int StoreId { get; set; }
        public virtual StationaryStore StationaryStore { get; set; } = default!;
        public int Salary { get; set; }

    }
}