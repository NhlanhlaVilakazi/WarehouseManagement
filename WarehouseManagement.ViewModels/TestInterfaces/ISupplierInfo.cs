namespace WarehouseManagent.ViewModels.Interfaces
{
    public interface ISupplierInfo
    {
        public string CompanyName { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsErrorMessageVisible { get; set; }

        public event EventHandler AttemptSave;
    }
}
