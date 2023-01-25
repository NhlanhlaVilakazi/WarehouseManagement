﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
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

        public int AddProduct(Product product)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@productName", product.ProductName),
                new SqlParameter("@supplierId", product.SupplierID),
                new SqlParameter("@categoryId", product.CategoryID),
                new SqlParameter("@quantityPerUnit", product.QuantityPerUnit),
                new SqlParameter("@unitPrice", product.UnitPrice),
                new SqlParameter("@unitsInStock", product.UnitsInStock),
                new SqlParameter("@unitsOnOrder", product.UnitsOnOrder),
                new SqlParameter("@reorderLevel", product.ReorderLevel),
                new SqlParameter("@discontinued", product.Discontinued),
                new SqlParameter("@productID",0){  Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Int, Size = 400 }
            };

            _dbContext.Database.ExecuteSqlRawAsync("NewProduct  @productName, @supplierId, @categoryId, @quantityPerUnit, @unitPrice" +
            "@unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued, @productID OUT", parameters).GetAwaiter().GetResult();
            return (int)(parameters[9].Value ?? 0);
        }
    }
}
