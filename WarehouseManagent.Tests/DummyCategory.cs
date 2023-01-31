using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagent.ViewModels.Interfaces;

namespace WarehouseManagent.Tests
{
    public class DummyCategory : ICategoryViewModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsErrorMessageVisible { get; set; }

        public event EventHandler AddBtn;

        public void Save() => AddBtn?.Invoke(this, EventArgs.Empty);
    }
}
