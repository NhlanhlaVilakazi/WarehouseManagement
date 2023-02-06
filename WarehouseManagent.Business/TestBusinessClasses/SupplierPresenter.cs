using WarehouseManagent.ViewModels.Interfaces;

namespace WarehouseManagent.Business.TestBusinessClasses
{
    public class SupplierPresenter
    {
        private readonly ISupplierInfo _supplierInfo;

        public SupplierPresenter(ISupplierInfo supplierInfo)
        {
            _supplierInfo = supplierInfo;
            _supplierInfo.AttemptSave += _supplierInfo_AttemptSave;
        }

        private void _supplierInfo_AttemptSave(object? sender, EventArgs e)
        {
            _supplierInfo.IsErrorMessageVisible = false;
            if (string.IsNullOrEmpty(_supplierInfo.CompanyName))
            {
                _supplierInfo.IsErrorMessageVisible = true;
                _supplierInfo.ErrorMessage = "Company name is required";
            }
            else
                _supplierInfo.ErrorMessage = string.Empty;
        }
    }
}
