using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModels
{
    public class StationaryStoreAdress : Address
    {
        public virtual StationaryStore StationaryStore { get; set; } = default!;
        [ForeignKey("StationaryStoreAddress")]
        public int StationaryStoreId { get; set; }
    }
}