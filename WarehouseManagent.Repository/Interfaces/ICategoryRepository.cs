using WarehouseManagent.Data.DataModels;

namespace WarehouseManagent.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        int AddCategory(Category category);
    }
}
