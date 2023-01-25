using Microsoft.EntityFrameworkCore;
using WarehouseManagent.Data;
using WarehouseManagent.Data.DataModels;
using WarehouseManagent.Repository.Interfaces;

namespace WarehouseManagent.Repository.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private DataContext _dbContext;

        public ProductRepository()
        {
            _dbContext = new();
        }
        public List<Product> GetAll()
        {
            const string query = "EXEC [GetAllProducts]";
            return _dbContext.Set<Product>().FromSqlRaw(query).ToList();
        }
    }
}
