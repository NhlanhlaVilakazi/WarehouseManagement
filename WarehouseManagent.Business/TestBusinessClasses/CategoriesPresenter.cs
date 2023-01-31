using WarehouseManagent.ViewModels.Interfaces;

namespace WarehouseManagent.Business.TestBusinessClasses
{
    public class CategoriesPresenter
    {
        private readonly ICategoryViewModel _categoryViewModel;

        public CategoriesPresenter(ICategoryViewModel categoryViewModel)
        {
            _categoryViewModel = categoryViewModel;
            _categoryViewModel.AddBtn += _categoryViewModel_AddBtn;
        }

        private void _categoryViewModel_AddBtn(object? sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_categoryViewModel.CategoryName))
            {
                _categoryViewModel.IsErrorMessageVisible = true;
                _categoryViewModel.ErrorMessage = "Category name can not be empty";
            }

        }
    }
}
