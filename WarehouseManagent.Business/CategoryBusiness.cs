using Microsoft.Extensions.DependencyInjection;
using WarehouseManagement.ViewModels;
using WarehouseManagent.Data.DataModels;
using WarehouseManagent.Repository;
using WarehouseManagent.Repository.Interfaces;

namespace WarehouseManagent.Business
{
    public class CategoryBusiness
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryBusiness()
        {
            _categoryRepository = ConfigureInjections.ServiceProvider.GetRequiredService<ICategoryRepository>();
        }

        public List<CategoryViewModel> GetCategories()
        {
            var categories = _categoryRepository.GetAll();
            return ObjectMapper.Mapper.Map<List<CategoryViewModel>>(categories);
        }

        public bool AddNewCategory(CategoryViewModel category)
        {
            var categoryModel = ObjectMapper.Mapper.Map<Category>(category);
            return _categoryRepository.AddCategory(categoryModel) > 0;
        }

        public bool RemoveCategory(int categoryID)
        {
            return _categoryRepository.DeteleCategory(categoryID) > 0;
        }

        public CategoryViewModel GetById(int categoryID)
        {
            var category = _categoryRepository.GetCategoryById(categoryID);
            return ObjectMapper.Mapper.Map<CategoryViewModel>(category);
        }

        public bool UpdateCategory(CategoryViewModel category)
        {
            var categoryModel = ObjectMapper.Mapper.Map<Category>(category);
            return _categoryRepository.UpdateCategory(categoryModel) > 0;
        }
    }
}
