using Microsoft.EntityFrameworkCore;
using WarehouseManagent.Data;
using WarehouseManagent.Data.DataModels;
using WarehouseManagent.Repository.Interfaces;

namespace WarehouseManagent.Repository.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private DataContext _dbContext;

        public CategoryRepository()
        {
            _dbContext = new();
        }
        public List<Category> GetAll()
        {
            const string query = "EXEC [GetAllCategories]";
            return _dbContext.Set<Category>().FromSqlRaw(query).ToList();
        }
    }
}
