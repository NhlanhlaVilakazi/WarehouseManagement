using WarehouseManagent.ViewModels.Interfaces;

namespace WarehouseManagent.Tests.DummyClasses
{
    public class DummySupplier : ISupplierInfo
    {
        public string CompanyName { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsErrorMessageVisible { get; set; }

        public event EventHandler AttemptSave;

        public void Save() => AttemptSave?.Invoke(this, EventArgs.Empty);
    }
}
