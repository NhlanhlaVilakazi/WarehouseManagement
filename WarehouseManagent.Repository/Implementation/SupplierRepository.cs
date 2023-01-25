using Microsoft.EntityFrameworkCore;
using WarehouseManagent.Data;
using WarehouseManagent.Data.DataModels;
using WarehouseManagent.Repository.Interfaces;

namespace WarehouseManagent.Repository.Implementation
{
    public class SupplierRepository : ISupplierRepository
    {
        private DataContext _dbContext;

        public SupplierRepository()
        {
            _dbContext = new DataContext();
        }

        public List<Supplier> GetAll()
        {
            const string query = "EXEC [GetAllSuppliers]";
            return _dbContext.Set<Supplier>().FromSqlRaw(query).ToList();
        }

        public void Dispose()
        {
            _dbContext = null;
        }
    }
}
