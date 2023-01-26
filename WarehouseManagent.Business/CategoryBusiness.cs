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
    }
}
