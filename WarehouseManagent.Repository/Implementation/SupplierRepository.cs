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
                new SqlParameter("@homePage", supplier.HomePage)
            };

           return _dbContext.Database.ExecuteSqlRawAsync("[NewSupplier]  @companyName, @contactName, @contactTitle, @address, " +
           "@city, region, @postalCode, @country, @phone, @fax, @homePage", parameters).GetAwaiter().GetResult();
        }

        public int DeleteSupplier(int supplierID)
        {
            SqlParameter[] parameter =
            {
                new SqlParameter("@supplierID", supplierID)
            };
            return _dbContext.Database.ExecuteSqlRawAsync("[DeleteSupplier] @supplierID", parameter).GetAwaiter().GetResult();
        }

        public Supplier? GetSupplierById(int supplierID)
        {
            SqlParameter[] parameter =
            {
                new SqlParameter("@supplierID", supplierID)
            };
            const string query = "EXEC [GetSupplier] @supplierID";
            return _dbContext.Set<Supplier>().FromSqlRaw(query, parameter).ToList().SingleOrDefault();
        }

        public int UpdateSupplier(Supplier supplier)
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
                new SqlParameter("@supplierID", supplier.SupplierID)
            };

            return _dbContext.Database.ExecuteSqlRawAsync("[UpdateSupplier]  @companyName, @contactName, @contactTitle, @address, " +
            "@city, region, @postalCode, @country, @phone, @fax, @homePage, @supplierID", parameters).GetAwaiter().GetResult();
        }
    }
}
