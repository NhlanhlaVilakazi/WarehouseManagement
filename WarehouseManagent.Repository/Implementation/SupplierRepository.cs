using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
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
            _dbContext = new();
        }

        public List<Supplier> GetAll()
        {
            const string query = "EXEC [GetAllSuppliers]";
            return _dbContext.Set<Supplier>().FromSqlRaw(query).ToList();
        }

        public int AddSupplier(Supplier supplier)
        {
            SqlParameter[] parameters = 
            {
                new SqlParameter("@companyName", supplier.ContactName),
                new SqlParameter("@contactName", supplier.ContactName),
                new SqlParameter("@contactTitle", supplier.ContactTitle),
                new SqlParameter("@address", supplier.Address),
                new SqlParameter("@city", supplier.City),
                new SqlParameter("@region", supplier.Region),
                new SqlParameter("@postalCode", supplier.PostalCode),
                new SqlParameter("@country", supplier.Country),
                new SqlParameter("@phone", supplier.Phone),
                new SqlParameter("@fax", supplier.Fax),
                new SqlParameter("@homePage", supplier.HomePage),
                new SqlParameter("@supplierID",0){  Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Int, Size = 400 }
            };

            _dbContext.Database.ExecuteSqlRawAsync("NewSupplier  @companyName, @contactName, @contactTitle, @address, " +
            "@city, region, @postalCode, @country, @phone, @fax, @homePage, @supplierID OUT", parameters).GetAwaiter().GetResult();
            return (int)(parameters[11].Value ?? 0);
        }

        public int DeleteSupplier(int supplierID)
        {
            SqlParameter[] parameter =
            {
                new SqlParameter("@supplierID", supplierID)
            };

            return _dbContext.Database.ExecuteSqlRawAsync("DeleteSupplier @supplierID", parameter).GetAwaiter().GetResult();
        }
    }
}
