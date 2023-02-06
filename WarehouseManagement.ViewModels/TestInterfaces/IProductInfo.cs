namespace WarehouseManagent.ViewModels.Interfaces
{
    public interface IProductInfo
    {
        public string ProductName { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsErrorMessageVisible { get; set; }
        public event EventHandler AttemptSave;
    }
}
