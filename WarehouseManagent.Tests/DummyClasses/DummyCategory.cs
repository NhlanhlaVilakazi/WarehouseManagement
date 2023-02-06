using WarehouseManagent.ViewModels.Interfaces;

namespace WarehouseManagent.Tests.DummyClasses
{
    public class DummyCategory : ICategoryInfo
    {
        public string CategoryName { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsErrorMessageVisible { get; set; }

        public event EventHandler AttemptSave;

        public void Save() => AttemptSave?.Invoke(this, EventArgs.Empty);
    }
}
