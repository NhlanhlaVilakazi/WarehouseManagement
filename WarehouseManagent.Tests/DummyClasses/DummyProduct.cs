using WarehouseManagent.ViewModels.Interfaces;

namespace WarehouseManagent.Tests.DummyClasses
{
    public class DummyProduct : IProductInfo
    {
        public string ProductName { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsErrorMessageVisible { get; set; }

        public event EventHandler AttemptSave;

        public void Save() => AttemptSave?.Invoke(this, EventArgs.Empty);
    }
}
