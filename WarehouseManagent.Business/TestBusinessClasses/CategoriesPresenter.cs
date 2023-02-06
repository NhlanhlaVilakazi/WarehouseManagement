using WarehouseManagent.ViewModels.Interfaces;

namespace WarehouseManagent.Business.TestBusinessClasses
{
    public class CategoriesPresenter
    {
        private readonly ICategoryInfo _categoryInfo;

        public CategoriesPresenter(ICategoryInfo categoryInfo)
        {
            _categoryInfo = categoryInfo;
            _categoryInfo.AttemptSave += _categoryInfo_AttemptSave;
        }

        private void _categoryInfo_AttemptSave(object? sender, EventArgs e)
        {
            _categoryInfo.IsErrorMessageVisible = false;
            if (string.IsNullOrEmpty(_categoryInfo.CategoryName))
            {
                _categoryInfo.IsErrorMessageVisible = true;
                _categoryInfo.ErrorMessage = "Category name is required";
            }
            else
                _categoryInfo.ErrorMessage = string.Empty;
        }
    }
}
