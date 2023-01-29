using WarehouseManagent.Data.DataModels;

namespace WarehouseManagent.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        int AddCategory(Category category);
        int DeteleCategory(int categoryID);
        Category? GetCategoryById(int categoryID);
        int UpdateCategory(Category category);
    }
}
