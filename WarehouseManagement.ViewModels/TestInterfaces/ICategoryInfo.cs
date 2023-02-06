namespace WarehouseManagent.ViewModels.Interfaces
{
    public interface ICategoryInfo
    {
        public string CategoryName { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsErrorMessageVisible { get; set; }
        public event EventHandler AttemptSave;
    }
}
