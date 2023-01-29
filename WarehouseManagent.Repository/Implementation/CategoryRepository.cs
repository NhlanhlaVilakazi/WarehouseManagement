using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection.Metadata;
using WarehouseManagent.Data;
using WarehouseManagent.Data.DataModels;
using WarehouseManagent.Repository.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        public Category? GetCategoryById(int categoryID)
        {
            SqlParameter[] parameter =
            {
                new SqlParameter("@categoryID", categoryID)
            };
            const string query = "EXEC [GetCategoryById] @categoryID";
            return _dbContext.Set<Category>().FromSqlRaw(query, parameter).ToList().SingleOrDefault();
        }

        public int UpdateCategory(Category category)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@categoryName", category.CategoryName),
                new SqlParameter("@description", category.Description),
                new SqlParameter("@picture", category.Picture),
                new SqlParameter("@categoryID", category.CategoryID)
            };
            return _dbContext.Database.ExecuteSqlRawAsync("UpdateCategory @categoryName, @description, @picture, @categoryID", parameters).GetAwaiter().GetResult();
        }
    }
}
