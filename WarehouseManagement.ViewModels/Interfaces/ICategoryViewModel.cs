using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagent.ViewModels.Interfaces
{
    public interface ICategoryViewModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsErrorMessageVisible { get; set; }
        public event EventHandler AddBtn;
    }
}
