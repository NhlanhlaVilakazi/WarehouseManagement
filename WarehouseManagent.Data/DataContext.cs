using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WarehouseManagent.Data.DataModels;

namespace WarehouseManagent.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public new DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(new SqlConnection(ServicesExtensions.appConnectionString));
        }
    }
}
