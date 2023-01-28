using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
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

        public int AddCategory(Category category)
        {
            SqlParameter[] parameters = 
            {
                new SqlParameter("@categoryName", category.CategoryName),
                new SqlParameter("@description", category.Description),
                new SqlParameter("@picture", category.Picture),
                new SqlParameter("@categoryID",0){  Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Int, Size = 400 }
            };

            _dbContext.Database.ExecuteSqlRawAsync("NewCategory  @categoryName, @description, @picture, @categoryID OUT", parameters).GetAwaiter().GetResult();
            return (int)(parameters[3].Value ?? 0);
        }

        public int DeteleCategory(int categoryID)
        {
            SqlParameter[] parameter = 
            {
                new SqlParameter("@categoryID", categoryID)
            };

            return _dbContext.Database.ExecuteSqlRawAsync("DeleteCategory @categoryID", parameter).GetAwaiter().GetResult();
        }
    }
}
