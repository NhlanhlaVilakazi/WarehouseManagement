using WarehouseManagent.ViewModels.Interfaces;

namespace WarehouseManagent.Business.TestBusinessClasses
{
    public class ProductPresenter
    {
        private readonly IProductInfo _productInfo;

        public ProductPresenter(IProductInfo productInfo)
        {
            _productInfo = productInfo;
            _productInfo.AttemptSave += _productInfo_AttemptSave;
        }

        private void _productInfo_AttemptSave(object? sender, EventArgs e)
        {
            _productInfo.IsErrorMessageVisible = false;
            if (string.IsNullOrEmpty(_productInfo.ProductName))
            {
                _productInfo.IsErrorMessageVisible = true;
                _productInfo.ErrorMessage = "Product name is required";
            }
            else
                _productInfo.ErrorMessage = string.Empty;
        }
    }
}
