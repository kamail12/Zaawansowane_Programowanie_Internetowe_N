namespace WebStore.ViewModels.VM;
public class StationaryStoreEmployeeVm : UserVm
{
    public int AggreementNumber {get; set;} 
    public DateTime Employment {get; set;} 
    public string Position { get; set; } = default!;
    public Decimal Salary { get; set; } = default!;
    public int StationaryStoreId { get; set; }
    public StationaryStoreVm StationaryStore { get; set; } = default!;
}